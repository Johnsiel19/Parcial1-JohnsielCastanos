Create database Parcial1JohnsielCastanos
go 
use Parcial1JohnsielCastanos
go


create table Productos(
ProductoId int primary key identity,
Descripcion nvarchar(MAX),
Existencia real, 
Costo real,
ValorInventario float
)

create table Inventarios(
InventarioId int,
Valor real)



 SET IDENTITY_INSERT Inventarios ON
insert into Inventarios(InventarioId, Valor) values('1','0');