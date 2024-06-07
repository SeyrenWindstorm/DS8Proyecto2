create database Proyecto


CREATE TABLE DatosCliente (
    codigo int PRIMARY KEY,
    dni VARCHAR(20),
    name VARCHAR(35),
    telefono VARCHAR(12),
	correo VARCHAR(30),
    fecha DATE,
	fechaf date,
	direccion VARCHAR(100),
	procu VARCHAR(25),
	estado VARCHAR(12),
);

CREATE TABLE Procuradores (
    dni VARCHAR(20)PRIMARY KEY,
    name VARCHAR(35),
    telefono VARCHAR(12),
	correo VARCHAR(30),
);

INSERT INTO Procuradores (dni, name, telefono, correo)
VALUES ('9-912-1561', 'Irma A. Gonzalez R.', '6206-2336','irmagonzalez@gmail.com'),
('8-812-123', 'Jose L. Martinez O..', '6461-9291','JoseMrtinz@gmail.com'),
('4-442-321', 'Gianncarlo S. Moran R.', '6686-1479','GianMoran@gmail.com'),
('6-612-614', 'Mario D. Ribas R.', '6206-2336','MarioDRR@gmail.com'),
('7-712-191', 'Giovana Y. Levitt R.', '6206-2336','GiovanaLevittR@gmail.com');

