use Automotriz_Castillo

create table Clientes(
	id_cliente int primary key identity(1000,1),
	nom varchar(30) not null,
	ap varchar(25) not null,
	am varchar(25) not null,
	tel varchar(10),
	correo varchar(60)
)