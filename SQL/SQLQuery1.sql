CREATE DATABASE TRABAJOFINAL
USE TRABAJOFINAL

-- CREACION DE LAS TABLAS PARA LA BASE DE DATOS
CREATE TABLE CARRERA (
	id_carrera INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreCarrera Varchar (50) NOT NULL
)

CREATE TABLE MAESTRO (
	id_user int NOT NULL PRIMARY KEY IDENTITY (1,1),
	username varchar(50) NOT NULL,
	password varchar(50) NOT NULL,
	nombre varchar(100) NOT NULL,
	id_carrera int,
	tipoUser varchar(50) NOT NULL DEFAULT 'Maestro',
	FOREIGN KEY (id_carrera) REFERENCES CARRERA(id_carrera)
)

CREATE TABLE MAESTRO_RES (
	id_user INT NOT NULL,
	fecha DATE,
	usuario VARCHAR (50),
	terminal VARCHAR (50),
	FOREIGN KEY (id_user) REFERENCES MAESTRO(id_user)
)

CREATE TABLE BECADOS (
	id_beca INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreBeca varchar(50) NOT NULL,
	monto INT NOT NULL,
	CONSTRAINT CK_BECADOS_monto CHECK (monto>= 10000)
)

CREATE TABLE ALUMNO (
	noControl INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	apellidoPaterno VARCHAR(50) NOT NULL,
	apellidoMaterno VARCHAR(50) NOT NULL,
	telefono VARCHAR(10) NOT NULL DEFAULT '0000000000',
	curp VARCHAR (50) NOT NULL,
	id_beca int,
	id_carrera int not null,
	FOREIGN KEY (id_beca) REFERENCES BECADOS(id_beca),
	FOREIGN KEY (id_carrera) REFERENCES CARRERA(id_carrera),
	CONSTRAINT UQ_ALUMNO_curp UNIQUE (curp)
)

CREATE TABLE ALUMNO_RES (
	noControl INT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellidoPaterno VARCHAR(50) NOT NULL,
	apellidoMaterno VARCHAR(50) NOT NULL,
	telefono VARCHAR(10),
	fecha DATE,
	usuario VARCHAR (50),
	terminal VARCHAR (50),
)

ALTER TABLE ALUMNO_RES ADD CONSTRAINT FK_ALUMNO_RES FOREIGN KEY (noControl) REFERENCES ALUMNO(noControl)

-- INSERSIONES DE DATOS EN LAS TABLAS
INSERT INTO CARRERA VALUES ('Administracion');
INSERT INTO CARRERA VALUES ('Aeronautica');
INSERT INTO CARRERA VALUES ('Mecanica');
INSERT INTO CARRERA VALUES ('Electrica');
INSERT INTO CARRERA VALUES ('Mecatronica');

INSERT INTO MAESTRO VALUES ('admin', 'admin', 'Armando', 1 ,'Administrador')
INSERT INTO MAESTRO (username, password, nombre, id_carrera) VALUES ('usuario1', 'usuario1', 'Jose', 3)
INSERT INTO MAESTRO VALUES ('usuario2', 'usuario2', 'Andrea', 4 ,'Administrador')
INSERT INTO MAESTRO VALUES ('usuario3', 'usuario3', 'Juan', 5 ,'Administrador')
INSERT INTO MAESTRO VALUES ('usuario4', 'usuario4', 'Roberto', 2 ,'Administrador')

INSERT INTO BECADOS VALUES ('Benito Juarez', 10000);
INSERT INTO BECADOS VALUES ('Becas y creditos', 10000);
INSERT INTO BECADOS VALUES ('Pancho Villa', 17000);
INSERT INTO BECADOS VALUES ('Teleton', 16000);
INSERT INTO BECADOS VALUES ('Esposos Rodriguez', 16000);

INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, telefono, curp, id_carrera) VALUES ('Marcos', 'Robles', 'Nava', 6221144128, 'RONM020124HSRB54', 5);
INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, telefono, curp, id_beca,id_carrera) VALUES ('Mariano', 'Rodriguez', 'Lopez', 6220044128, 'KJHG030124HSRB54', 1,1);
INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, telefono, curp, id_beca, id_carrera) VALUES ('Jose', 'Hernandez', 'Rivera', 6561143128, 'JOHERI24HSRB54', 5,5);
INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, telefono, curp, id_beca, id_carrera) VALUES ('Carlos', 'Mejia', 'Bawman', 6987144128, 'BAWM50132454RB54', 3,4);
INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, telefono, curp, id_beca, id_carrera) VALUES ('Camila', 'Valenzuela', 'Ruiz', 6581145137, 'CAMV52124MJRB72', 4, 3);

-- CAMBIOS
UPDATE ALUMNO  set id_beca=null where noControl= 1
select * from ALUMNO where noControl=1

UPDATE BECADOS set monto=18000 where nombreBeca='Esposos Rodriguez'
UPDATE CARRERA set nombreCarrera='Administracion de Empresas' WHERE id_carrera=1

--CONSULTAS
SELECT nombre, id_carrera FROM ALUMNO
SELECT * FROM BECADOS where monto between 10000 and 15000
SELECT id_user, nombre FROM MAESTRO

-- JOIN
SELECT A.nombre, M.nombre, A.id_carrera, C.nombreCarrera FROM ALUMNO AS A INNER JOIN CARRERA AS C ON C.id_carrera=A.id_carrera INNER JOIN MAESTRO AS M ON M.id_carrera=C.id_carrera

SELECT * FROM ALUMNO AS A LEFT JOIN BECADOS AS B ON A.id_beca=B.id_beca

--VISTAS
CREATE VIEW VISTA1 AS SELECT nombre, id_carrera FROM MAESTRO

CREATE VIEW VISTA2 AS SELECT nombre, apellidoPaterno, apellidoMaterno, id_carrera from ALUMNO

CREATE VIEW VISTA3 AS SELECT C.nombreCarrera, M.nombre, M.id_carrera FROM CARRERA AS C INNER JOIN MAESTRO AS M ON C.id_carrera=M.id_carrera


select * FROM VISTA1
select * FROM VISTA2
select * FROM VISTA3


-- CREACION DE LOS DISTINTOS TRIGGER UTILIZADOS
CREATE TRIGGER bitacora_RegistroMaestros
ON MAESTRO
after INSERT
AS
BEGIN
INSERT INTO
MAESTRO_RES(id_user,fecha,usuario,terminal) SELECT
id_user,getdate(),system_user,host_name() FROM inserted
END;

CREATE TRIGGER bitacora_RegistroEstudiantes
ON ALUMNO
after INSERT
AS
BEGIN
INSERT INTO
ALUMNO_RES(noControl,nombre,apellidoPaterno,apellidoMaterno,telefono,fecha,usuario,terminal) SELECT
noControl,nombre,apellidoPaterno,apellidoMaterno,telefono,getdate(),system_user,host_name() FROM inserted
END;

--PROCEDIMIENTOS ALMACENADOS
--VISUALIZAR UN ALUMNO CON SU CURP
CREATE PROCEDURE WSP_CURP
@CURP varchar(50)
AS
BEGIN
 SELECT * FROM ALUMNO WHERE curp = @CURP
END

CREATE PROCEDURE BAJA_ALUMNO
@WCONTROL INT
AS
begin
If not exists(SELECT * FROM ALUMNO where noControl=@WCONTROL) BEGIN
Print 'ESTE ALUMNO NO EXISTE….'
 RETURN
 END
If exists(SELECT * FROM ALUMNO where noControl=@WCONTROL)
BEGIN
	ALTER TABLE ALUMNO_RES NOCHECK CONSTRAINT FK_ALUMNO_RES;
	DELETE FROM ALUMNO WHERE noControl=@WCONTROL
	ALTER TABLE ALUMNO_RES CHECK CONSTRAINT FK_ALUMNO_RES;
	PRINT 'EL ALUMNO FUE DADO DE BAJA….'
 RETURN
END
END

CREATE PROCEDURE INSERTAR_ALUMNO
@WNOMBRE VARCHAR (50),
@WAPELLIDOPATERNO VARCHAR(50) ,
@WAPELLIDOMATERNO VARCHAR(50),
@WTELEFONO VARCHAR(10) ,
@WCURP VARCHAR (50),
@WID_CARRERA int

AS
        BEGIN
                IF EXISTS (SELECT *  FROM ALUMNO WHERE curp = @WCURP)

                BEGIN
                PRINT ' EL ALUMNO YA ESTA INSCRITO EN EL SISTEMA'
                RETURN
                END
                BEGIN
                IF NOT EXISTS (SELECT * FROM ALUMNO WHERE curp = @WCURP)

                BEGIN
INSERT INTO ALUMNO (nombre, apellidoPaterno, apellidoMaterno, telefono, curp,id_carrera)
VALUES (@WNOMBRE, @WAPELLIDOPATERNO, @WAPELLIDOMATERNO, @WTELEFONO, @WCURP, @WID_CARRERA)
PRINT ' ALUMNO INSCRITO DE MANERA EXITOSA'
END
END
END

EXEC WSP_CURP @CURP =  'RONM020124HSRB54'
EXEC BAJA_ALUMNO '9'
EXEC INSERTAR_ALUMNO 'Paola', 'Ruiz', 'Cordova', '0000001220', 'JNORQ121098230', 1;

SELECT name FROM sys.procedures
SELECT name FROM sys.triggers
SELECT name, object_id, parent_object_id, referenced_object_id FROM sys.foreign_keys

DROP TABLE ALUMNO_RES
DROP TABLE ALUMNO
DROP TABLE BECADOS
DROP TABLE MAESTRO_RES
DROP TABLE MAESTRO
DROP TABLE CARRERA

select * FROM ALUMNO
select * FROM MAESTRO
SELECT * FROM BECADOS
SELECT * FROM CARRERA
select * FROM ALUMNO_RES
SELECT * FROM MAESTRO_RES
