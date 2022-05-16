CREATE DATABASE concesionariaSPA
GO
USE concesionariaSPA
GO

CREATE TABLE VEHICULO(
Id int NOT NULL Identity,
Marca VARCHAR(50),
Modelo VARCHAR(50),
Año INT,
Kilometros FLOAT,
Precio FLOAT,

Primary Key(Id),
)

INSERT INTO VEHICULO(Marca,Modelo,Año,Kilometros,Precio) values ('Chevrolet','Corsa',2012,125000,600.500)
INSERT INTO VEHICULO(Marca,Modelo,Año,Kilometros,Precio) values ('Renault','Sandero',2016,90000,900.300)
INSERT INTO VEHICULO(Marca,Modelo,Año,Kilometros,Precio) values ('Renault','Logan',2014,80000,900.500)