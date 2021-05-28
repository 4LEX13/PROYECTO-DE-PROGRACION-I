CREATE DATABASE AdministracionEscolar
use AdministracionEscolar

create table Usuario(
usuarioId int primary key identity not null,
correo_Usuario varchar(50)unique,
contrasena varchar(50),
tipo_Rol varchar (50)

);