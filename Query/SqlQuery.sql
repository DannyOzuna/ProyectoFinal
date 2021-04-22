/*create table vehiculos(
	id int primary key identity,
	marca varchar(30),
	modelo varchar(30),
	anio varchar(10),
	color varchar(20),
	precio decimal(16,2),
	Tipo varchar(30),
	capacidad float,
	pasajeros int,
	matricula varchar(50),
	nro_seguro varchar(30),
	foto varchar(255),
	latitud varchar(100),
	longitud varchar(100)
)*/

/*create table clientes(
	id int primary key identity, 
	cedula varchar(13) unique, 
	nombre varchar(30), 
	apellido varchar(30),
	correo varchar(50),
	licencia varchar(30),
	nacionalidad varchar(30),
	tipo_sangre varchar(5),
	foto_persona varchar(255), 
	foto_licencia varchar(255),
	estado int
)*/


/*create table reservas(
	id int primary key identity(1,1),
	id_vehiculo int FOREIGN KEY REFERENCES vehiculos (id),
	id_cliente int FOREIGN KEY REFERENCES clientes (id),
	fecha_inicia date,
	fecha_fin date,
	estado int
)*/



insert into vehiculos values ('Honda', 'CR-V', '2017', 'Gris', 300.00, 'Jeepeta', 23.4, 4,'DO1001','FULL','url','123','456', 0);


select * from clientes


update vehiculos set estado = 1;
