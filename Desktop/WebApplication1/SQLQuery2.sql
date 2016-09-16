CREATE TABLE Clientes (
	Cedula		CHAR(13)	PRIMARY KEY		NOT NULL,
	Nombre		CHAR(20)	NOT NULL,
	Apellido1	CHAR(20)    NOT NULL,
	Apellido2	CHAR(20)	NOT NULL,
	Correo		CHAR(40)	NOT NULL,
	Direccion	CHAR(50),
 )

 CREATE TABLE Telefono (
	Numero		CHAR(14)	PRIMARY KEY 	NOT NULL,
	ClienteId_fk	CHAR(13)	NOT NULL,
	FOREIGN KEY (ClienteId_fk) REFERENCES Clientes (Cedula)
 )

 CREATE TABLE Cuenta (
	Cuenta		CHAR(30)	PRIMARY KEY	NOT NULL,
	ClienteCId_fk	CHAR(13)	NOT NULL,
	FOREIGN KEY (ClienteCId_fk) REFERENCES Clientes (Cedula)
 )

 Select * from AspNetUsers;