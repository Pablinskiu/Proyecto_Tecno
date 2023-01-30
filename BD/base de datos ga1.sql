use Iogin
select *from usuarios
create table usuarios2
	(
	id int not null primary key,
	nombre varchar(100),
	correo varchar(100),
	pais varchar(100),
	ocupacion varchar (100)
	)
select *from usuarios2