Create database Parcial1JohnsielCastanos
go 
use Parcial1JohnsielCastanos
go


create table Productos(
ProductoId int primary key identity,
Descripcion varchar(50),
Existencia int, 
Costo float,
ValorInventario float
)