use PruebaDev
go

 

IF EXISTS (
    SELECT * FROM information_schema.tables
    WHERE table_schema = 'dbo' AND table_name = 'Movimiento')     
       BEGIN
             ALTER TABLE Movimiento DROP CONSTRAINT FK_Movimiento_Empleado
             ALTER TABLE Movimiento DROP CONSTRAINT FK_Movimiento_Mes
             DROP TABLE dbo.Movimiento;
       END

create table dbo.Movimiento
(
    Id_Num_Empleado				int,
    Id_Num_Mes					int,
    Horas_Trabajadas			int,
    Cant_Entrega				int,
    primary key(Id_Num_Empleado,Id_Num_Mes)
)

IF EXISTS (
    SELECT * FROM information_schema.tables
    WHERE table_schema = 'dbo' AND table_name = 'Empleado')
       BEGIN
             ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Rol
             DROP TABLE dbo.Empleado;
       END

create table dbo.Empleado
(
       Id_Num_Empleado     int primary key,
       Nombre              varchar(100),
       NumeroEmpleado      varchar(50),
       Id_Num_Rol          int,
)

IF EXISTS (
    SELECT * FROM information_schema.tables
    WHERE table_schema = 'dbo' AND table_name = 'Rol_Pago')
       BEGIN
             ALTER TABLE Rol_Pago DROP CONSTRAINT FK_Rol_Pago_Rol
             DROP TABLE dbo.Rol_Pago;
       END

create table dbo.Rol_Pago
(
       Id_Num_RolPago      int primary key,
       Id_Num_Rol          int,
       SueldoBase          decimal(10,2),
       PagoPorEntrega      decimal(10,2),
       BonoHora            decimal(10,2),
)

IF EXISTS (
    SELECT * FROM information_schema.tables
    WHERE table_schema = 'dbo' AND table_name = 'Rol')      
    DROP TABLE dbo.Rol;

create table dbo.Rol
(
       Id_Num_Rol    int primary key,
       Nombre        varchar(20)
)

IF EXISTS (
    SELECT * FROM information_schema.tables
    WHERE table_schema = 'dbo' AND table_name = 'Mes')      
    DROP TABLE dbo.Mes;

create table dbo.Mes
(
       Id_Num_Mes    int primary key,
       Nombre        varchar(20) 
)

ALTER TABLE Movimiento
ADD CONSTRAINT FK_Movimiento_Empleado
FOREIGN KEY (Id_Num_Empleado) REFERENCES Empleado(Id_Num_Empleado);

ALTER TABLE Movimiento
ADD CONSTRAINT FK_Movimiento_Mes
FOREIGN KEY (Id_Num_Mes) REFERENCES Mes(Id_Num_Mes);

ALTER TABLE Empleado
ADD CONSTRAINT FK_Empleado_Rol
FOREIGN KEY (Id_Num_Rol) REFERENCES Rol(Id_Num_Rol);

ALTER TABLE Rol_Pago
ADD CONSTRAINT FK_Rol_Pago_Rol
FOREIGN KEY (Id_Num_Rol) REFERENCES Rol(Id_Num_Rol);

INSERT INTO Rol (Id_Num_Rol, Nombre) SELECT 1,'Chofer'
INSERT INTO Rol (Id_Num_Rol, Nombre) SELECT 2,'Cargador'
INSERT INTO Rol (Id_Num_Rol, Nombre) SELECT 3,'Auxiliar'

INSERT INTO Rol_Pago (Id_Num_RolPago,Id_Num_Rol,SueldoBase,PagoPorEntrega,BonoHora) SELECT 1,1,30.00,5.00,10.00
INSERT INTO Rol_Pago (Id_Num_RolPago,Id_Num_Rol,SueldoBase,PagoPorEntrega,BonoHora) SELECT 2,2,30.00,5.00,5.00
INSERT INTO Rol_Pago (Id_Num_RolPago,Id_Num_Rol,SueldoBase,PagoPorEntrega,BonoHora) SELECT 3,3,30.00,5.00,0.00

INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 1,'Enero'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 2,'Febrero'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 3,'Marzo'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 4,'Abril'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 5,'Mayo'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 6,'Junio'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 7,'Julio'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 8,'Agosto'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 9,'Septiembre'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 10,'Octubre'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 11,'Noviembre'
INSERT INTO mes     (Id_Num_Mes,Nombre) SELECT 12,'Diciembre'

SELECT * FROM Rol
SELECT * FROM Rol_Pago
SELECT * FROM Mes
SELECT * FROM Empleado

--exec Empleados 'I',null,'Miguel Hernandez','123456789',1
----exec Empleados 'I',null,'Miguel Hernandez','123456788',2
----exec Empleados 'I',null,'Miguel Hernandez','123456787',3
----exec Empleados 'D',7
----exec Empleados 'U',8,'Miguel Hernandez Gonzalez','123456789',2
exec Empleados 'S',3

--exec Movimientos 'I',1,2,10,28
--exec Movimientos 'I',2,2,10,28
--exec Movimientos 'I',3,2,10,28
--exec Movimientos 'S',1
--exec Movimientos 'U',1,1,10,28
----exec Movimientos 'D',8,1
--exec Movimientos 'S',1

exec CalculoSueldoMensualEmpleado


