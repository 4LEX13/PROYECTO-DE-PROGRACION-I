use master;
drop database if exists  GestorEstudiantes
create database GestorEstudiantes
go
use GestorEstudiantes
go


create table Usuarios(

Id_Usuarios int not null primary key identity,
Nombre_User varchar(100),
Pass varchar(100)

);

Create table Alumnos(
 
    alumnoid int not null IDENTITY PRIMARY KEY,
    nombre varchar(50),
	Apellidos varchar(100),
    --carreraid_fk int references Carreras(carreraid)
);


create table Materias(
    materiaid int not null IDENTITY PRIMARY KEY,
    nombre varchar(50)
    
);
 
create table Notas(
 
    notaid int not null IDENTITY PRIMARY KEY,
    periodo int,
    nota DECIMAL(5,2),
	materiaid_fk int references Materias(materiaid),
    alumnoid_fk int REFERENCES Alumnos(alumnoid) -- integridad referencial

	);

create table Docente(
    docenteid int not null IDENTITY PRIMARY KEY,
    nombre varchar(50),
    apellido varchar(50),
    --grado_fk int REFERENCES Alumnos(alumnoid)
);



Insert into Alumnos(nombre,Apellidos) values  ('Josue','guardado'),
                                            ('Ana','Menjivar'),
                                            ('Fernando','Tejada'),
                                            ('Rosa','Perez');

 Insert into Materias(nombre) values  ('Matematica'),('Sociales'),('Ciencias'),('Lenguaje');
Insert into Notas values(1,6,1,1),(2,6.5,1,1),(3,8,1,1);
                     
          
select * from Notas
insert into Usuarios  values ('Jose','prueba1'),
                            ('Admin','123'),
					        ('Carmen','145')


--Select b.nombre alumno,b.Apellidos alumno,c.nombre materia,a.periodo,a.nota from notas a 
--inner join alumnos b on a.alumnoid_fk=b.alumnoid
--inner join Materias c on a.materiaid_fk=c.materiaid