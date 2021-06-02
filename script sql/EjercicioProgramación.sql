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
create table Encargado (
encargadoId int primary key identity not null,
nombreEncargado varchar(75),
apellidoEncargado varchar(75),
identificacionEncargado varchar(25),
contactoEncargado varchar(25),
correoEncargado varchar(50) default('ninguno')
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

alter table Alumnos add encargadoFK int references Encargado(encargadoId)


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

create table Grado(
gradoId int primary key identity not null,
nombreGrado varchar(25),
)

create table Seccion(
seccionId int primary key identity not null,
nombreSeccion char

);

create table Matricula(
matriculaId int primary key identity not null,
alumnoFk int references Alumno(alumnoId),
gradoFk int references Grado(gradoId),
seccionFk int references Seccion(seccionId),
nombreMatricula  varchar (50),
fechaRegistroMatricula date default getdate()
);

select * from Matricula