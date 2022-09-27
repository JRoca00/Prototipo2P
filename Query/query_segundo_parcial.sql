create database SegundoParcial676;
use SegundoParcial676;

create table tbl_productos(
pk_codigo_producto int not null primary key auto_increment,
descripcion varchar(100),
Categoria varchar(100),
Nombre varchar(50),
marca varchar(100)
);

create table tbl_compras(
pk_compra int not null primary key auto_increment,
fk_codigo_producto int not null,
fecha_compra varchar(100),
costo int,
foreign key (fk_codigo_producto) references tbl_productos (pk_codigo_producto)
);


create table tbl_lote(
pk_codigo_lote int not null primary key auto_increment,
fk_codigo_producto int not null,
fecha varchar(50),
foreign key (fk_codigo_producto) references tbl_productos (pk_codigo_producto)
);


create table tbl_inventario(
pk_inventario int not null primary key auto_increment,
fk_codigo_producto int not null,
fk_lote int not null,
existencias int,
foreign key (fk_codigo_producto) references tbl_productos (pk_codigo_producto),
foreign key (fk_lote) references tbl_lote (pk_codigo_lote)
);



