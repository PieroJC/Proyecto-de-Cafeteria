create database autoservicio
use autoservicio

create table ventas(
idVentas int primary key not null,
idProd int not null,
monto decimal not null,
cantProd int not null,
idTicket int not null,
idInventario int not null
)

create table producto (
idProducto int primary key not null,
nomProd varchar(20) not null,
precio decimal not null
)

create table compras(
idCompra int primary key not null,
idProd int not null,
idProveedor int not null
)

create table proveedor (
idProveedor int  primary key not null,
dirProveedor varchar(50) not null,
telefonoProv int not null,
)

create table inventario(
idInventario int primary key not null,
idProveedor int not null,
idProducto int not null,
idPromocion int not null,
idTienda int not null
)

create table tienda (
idTienda int primary key not null,
nomTienda varchar(20) not null,
dirTienda varchar(50) not null,
telTienda varchar(50) not null,
gerenteTienda varchar(20) not null
)

create table seccion (
idSeccion int primary key not null,
nomSeccion varchar(20) not null,
idInventario int not null
)

create table promocion(
idPromocion int primary key not null,
fechaInicio date,
fechaFin date
)

create table empleados(
idEmpleado int primary key not null,
nomEmpleado varchar(20) not null,
dirEmpleado varchar(50) not null,
telEmpleado int not null,
idRango int not null,
idTienda int not null
)

create table rango(
idRango int not null,
nivel varchar (10)
)

create table ticket(
idTicket int primary key not null,
idTienda int not null,
idTipoPago int not null,
idEmpleado int not null,
fechaVenta date not null,
idFactura int not null  
)

create table factura(
idFactura int primary Key not null,
idTicket int not null,
montoFactura decimal not null,
fechaFactura date)

--relaciones 
--relacion de da