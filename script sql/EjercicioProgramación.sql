use master;
drop database if exists  AdministracionEscolar
create database AdministracionEscolar
go
use AdministracionEscolar
go

create table Usuario(
usuarioId int primary key identity not null,
correo_Usuario varchar(50)unique,
contrasena varchar(50),
tipo_Rol varchar (50)
);

create table Direccion(
direccionId int primary key identity not null,
residencia varchar(100),
municipio varchar(50),
departamento varchar(50)

);

create table Alumno(
alumnoId int primary key identity not null,
nombre varchar(75),
apellidoPaterno varchar(50),
apellidoMaterno varchar(50),
genero varchar(25),
fechaNacimiento date,
direccionFk int references Direccion(direccionId),
contacto varchar(25) default('ninguno'),
correo varchar(50) default('ninguno'),
activo int,
fechaRegistro date default getdate()
);

create table Encargado (
encargadoId int primary key identity not null,
alumnoFk int references Alumno(alumnoId),
nombre varchar(75),
apellido varchar(75),
identificacion varchar(25),
contacto varchar(25),
correo varchar(50) default('ninguno')
);

create table Maestro(
maestroId int primary key identity not null,
nombre varchar(75),
apellido varchar(75),
identificacion varchar(25),
genero varchar(25),
fechaNacimiento date,
direccionFk int references Direccion(direccionId),
contacto varchar(25),
correo varchar(75) ,
activo int,
fechaRegistro date default getdate()
);

