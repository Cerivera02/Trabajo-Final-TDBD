CREATE DATABASE TRABAJOFINAL
USE TRABAJOFINAL

-- CREACION DE LAS TABLAS PARA LA BASE DE DATOS
CREATE TABLE MAESTRO (
	id_user int NOT NULL PRIMARY KEY IDENTITY (1,1),
	username varchar(50) NOT NULL,
	password varchar(50) NOT NULL,
	tipoUser varchar(50) NOT NULL
)

CREATE TABLE MAESTRO_RES (
	id_user INT NOT NULL,
	fecha DATE,
	usuario VARCHAR (50),
	terminal VARCHAR (50),
	FOREIGN KEY (id_user) REFERENCES MAESTRO(id_user)
)

CREATE TABLE ALUMNO (
	noControl INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	apellidoPaterno VARCHAR(50) NOT NULL,
	apellidoMaterno VARCHAR(50) NOT NULL,
	telefono VARCHAR(10) NOT NULL DEFAULT '0000000000'
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
	FOREIGN KEY (noControl) REFERENCES ALUMNO(noControl)
)

-- CREACION DE LOS DISTINTOS TRIGGER UTILIZADOS
CREATE TRIGGER bitacora_usuarios
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

-- INSERSIONES DE DATOS EN LAS TABLAS
INSERT INTO MAESTRO(username, password, tipoUser) VALUES ('admin', 'admin', 'Administrador')
INSERT INTO MAESTRO(username, password, tipoUser) VALUES ('user', 'user', 'Maestro')
INSERT INTO MAESTRO(username, password, tipoUser) VALUES ('user2', 'user2', 'Maestro')
INSERT INTO MAESTRO(username, password, tipoUser) VALUES ('user3', 'user3', 'Maestro')
INSERT INTO MAESTRO(username, password, tipoUser) VALUES ('user4', 'user4', 'Maestro')

select * FROM ALUMNO
select * FROM ALUMNO_RES
select * FROM MAESTRO
select * FROM MAESTRO_RES
