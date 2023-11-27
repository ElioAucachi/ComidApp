drop database if exists 5to_comidapp;

create database 5to_comidapp;

use 5to_comidapp;

CREATE table Restaurant

(

idRestaurant SMALLINT UNSIGNED,

restaurante varchar(45),

domicilio varchar(45) not null,

email varchar(45) not null unique,

pasword char(64),

primary key (idRestaurant),

FULLTEXT (restaurant )

);

create table Plato

(

Plato varchar(45),

descripcion varchar (45),

precio decimal(7,2),

idRestaurant SMALLINT UNSIGNED,

disponible bool,

idPLato mediumint unsigned,

primary key(idPlato),

CONSTRAINT FK_Restaurant_Plato FOREIGN KEY (idRestaurant)

REFERENCES Restaurant(idRestaurant),

FULLTEXT (Plato,descripcion)

);

create table Cliente

(

idCliente mediumint unsigned,

email varchar(45) not null unique,

cliente varchar(45),

apellido varchar(45),

pasword char(64),

primary key (idCliente)

);

create table Pedido

(

idCliente mediumint unsigned,

numero mediumint unsigned not null,

idRestaurant SMALLINT UNSIGNED,

idPlato int,

fecha datetime,

valoracion float(10)not null,

descripcion varchar(45)not null,

primary key (numero),

constraint fk_Restaurant_Pedido foreign key(idRestaurant)

references Restaurant(idRestaurant),

constraint FK_Cliente_idCliente foreign key(idCliente)

references Cliente(idCliente)

);

create table PlatoPedido

(

idPlato mediumint unsigned,

numero mediumint unsigned,

cantPlatos tinyint unsigned,

detalle decimal(7,2),

constraint pk_PlatoPedido primary key(idPlato,numero),

constraint FK_PlatoPedido foreign key(idPlato)

references Plato(idPlato),

constraint f_PlatoPedido foreign key(numero)

references Pedido(numero)

);



CREATE TABLE VentaResto (

idResto mediumint unsigned,

IdPlato mediumint unsigned,

anio datetime,

mes datetime,

monto DECIMAL(9,2),

PRIMARY KEY (idResto, IdPlato, anio, mes),

constraint fK_VentaResto foreign key (IdPlato) references Plato(IdPlato)

);

