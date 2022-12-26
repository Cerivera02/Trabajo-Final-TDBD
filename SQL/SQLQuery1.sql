CREATE DATABASE TRABAJOFINAL
USE TRABAJOFINAL

CREATE TABLE USUARIO (
	username varchar(50) NOT NULL,
	password varchar(50) NOT NULL
)

INSERT INTO USUARIO (username, password) VALUES ('admin', 'admin')