CREATE DATABASE TRABAJOFINAL
USE TRABAJOFINAL

CREATE TABLE USUARIO (
	id_user int NOT NULL PRIMARY KEY IDENTITY (1,1),
	username varchar(50) NOT NULL,
	password varchar(50) NOT NULL,
	tipoUser varchar(50) NOT NULL
)

CREATE TABLE USUARIO_RES (
	id_user INT NOT NULL,
	fecha DATE,
	usuario VARCHAR (50),
	terminal VARCHAR (50),
	FOREIGN KEY (id_user) REFERENCES USUARIO(id_user)
)

CREATE TRIGGER bitacora_usuarios
ON USUARIO
after INSERT
AS
BEGIN
INSERT INTO
USUARIO_RES(id_user,fecha,usuario,terminal) SELECT
id_user,getdate(),system_user,host_name() FROM inserted
END;

INSERT INTO USUARIO (username, password, tipoUser) VALUES ('admin', 'admin', 'Administrador')
INSERT INTO USUARIO (username, password, tipoUser) VALUES ('user', 'user', 'Usuario Normal ')
INSERT INTO USUARIO (username, password, tipoUser) VALUES ('user2', 'user2', 'Usuario Normal 2')
INSERT INTO USUARIO (username, password, tipoUser) VALUES ('user3', 'user3', 'Usuario Normal 3')
INSERT INTO USUARIO (username, password, tipoUser) VALUES ('user4', 'user4', 'Usuario Normal 4')

select * FROM USUARIO
select * FROM Usuario_res



