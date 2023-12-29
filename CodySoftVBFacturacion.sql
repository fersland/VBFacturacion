use CodySoftVBFacturacion
GO
create table Clientes(
	Id int identity(1,1),
	Cedula varchar(13) not null,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null

	constraint pk_clientes_pid primary key(Id)
)

create table Proveedores(
	Id int identity(1,1) not null,
	Identificacion varchar(13) null,
	Nombre varchar(100) null

	constraint pk_proveedor_id primary key(Id)
)

create table Productos(
	Id int identity(1,1) not null,
	Descripcion varchar(100) not null,
	Precio decimal(18,2) not null,
	Stock int null

	constraint pk_productos_pid primary key(Id)
)

create table Compras(
	Id int identity(1,1) not null,
	Factura as ('COMP-' + RIGHT('00000' + CONVERT(VARCHAR, Id), (5))),
	ProveedorId int,
	Total decimal(18,2),
	FechaCompra datetime,

	constraint pk_compras_pid primary key(Id),
	constraint fk_compras_proveedores foreign key (ProveedorId) references Proveedores(Id)
)

create table Ventas(
	Id int identity(1,1) not null,
	NFactura as ('VENT-' + RIGHT('00000' + CONVERT(VARCHAR, Id), (5))),
	ClienteId int,
	Total decimal(18,2),
	FechaVenta datetime,

	constraint pk_ventas_pid primary key(Id),
	constraint fk_ventas_clientes foreign key (ClienteId) references Clientes(Id)
)

create table VentasDetalle(
	Id int identity(1,1) not null,
	NFactura int,
	ProductoId int,
	Cantidad int,
	Precio decimal(18,2) null,
	Iva decimal(18,2),
	Importe decimal(18,2) null,
	ImporteMasIva decimal(18,2)

	constraint pk_ventasdetalle_pid primary key(Id),
	constraint fk_ventas_productos foreign key (ProductoId) references Productos (Id)
)

-- DROP TABLE IF EXISTS ComprasDetalle
create table ComprasDetalle(
	Id int identity(1,1) not null,
	Factura int,
	ProductoId int,
	Precio decimal(18,2),
	Cantidad int,
	Iva decimal(18,2),
	Importe decimal(18,2),
	ImporteMasIva decimal(18,2)

	constraint pk_comprasdetalle_pid primary key(Id),
	constraint fk_comprasdetalle_productos foreign key (ProductoId) references Productos(Id)
)

GO
-- P R O C E D U R E
create procedure SP_CLIENTES_GUARDAR(
@cedula varchar(13),
@nombres varchar(50),
@apellidos varchar(50)
)

AS
	BEGIN
		INSERT INTO Clientes (Cedula, Nombres, Apellidos) VALUES (@cedula, @nombres, @apellidos)
	END

GO
create procedure SP_CLIENTES_LISTAR
AS
	BEGIN
		SELECT * FROM Clientes
	END
go
create procedure SP_CLIENTES_EDITAR(
@id int,
@cedula varchar(13),
@nombres varchar(50),
@apellidos varchar(50)
)

AS
	BEGIN
		UPDATE Clientes SET Cedula=@cedula, Nombres=@nombres, Apellidos=@apellidos WHERE Id=@id
	END

GO

create procedure SP_CLIENTES_ELIMINAR(@id int)
AS
	BEGIN
		DELETE FROM Clientes WHERE Id=@id
	END

GO

create procedure SP_PRODUCTOS_LISTAR
as
	begin
		select * from Productos
	end

-- exec SP_PRODUCTOS_LISTAR
GO

CREATE PROCEDURE SP_VENTAS(@factura as int, @cliente as int, @total as decimal(18,2))
AS
	
	if exists (select * from Ventas where Id=@factura)
	
	begin
		print 'Esta venta ya existe' + @factura
		return
	end

	begin
		insert into Ventas (Id, ClienteId, Total, FechaVenta) VALUES
						   (@factura, @cliente, @total, getdate())
	end
GO

create procedure SP_VENTAS_DETALLE
	(@NFactura varchar(20), @producto int, @cant int, @precio decimal(18,2), @importe decimal(18,2))
as
	begin 
		insert into VentasDetalle (NFactura, ProductoId, Cantidad, Precio, Importe)
			values (@NFactura, @producto, @cant, @precio, @importe)
	end

go
CREATE PROCEDURE SP_VENTAS_DETALLE_LISTA (@factura as integer)
AS
	BEGIN
		SELECT t2.Id, t2.Descripcion, t2.Precio, t1.Cantidad, t1.Iva, t1.Importe, t1.ImporteMasIva
				FROM VentasDetalle t1 
					INNER JOIN Productos t2 ON t1.ProductoId = t2.Id
			WHERE t1.NFactura =@factura
	END
go
--exec SP_VENTAS_DETALLE_LISTA 4

CREATE PROCEDURE SP_PROVEEDORES_LISTAR
as
	BEGIN
		SELECT * FROM proveedores
	END

go
	
	
CREATE PROCEDURE SP_COMPRAS_DETALLE (@factura as int, @producto as int, @precio as decimal(18,2), @cant as int, @iva as decimal(18,2), @importe as decimal(18,2), @importeMasIva as decimal(18,2))
as
	begin
		insert into ComprasDetalle (Factura, ProductoId, Precio, Cantidad, Iva, Importe, ImporteMasIva) values
									(@factura, @producto, @precio, @cant, @iva, @importe, @importeMasIva)
	end




GO
create procedure SP_COMPRASDETALLE_LISTAR (@factura as integer)
as
	begin
		select * from ComprasDetalle where Factura = @factura
	end
GO



create procedure SP_COMPRAS (@factura as int, @proveedor as integer, @total as decimal(18,2))
as
	if exists(select Id from Compras where Id = @factura ) raiserror('El numero de compra ya se encuentra e la bd',16,1)
	else
		insert into Compras (ProveedorId, Total, FechaCompra) values 
							(@proveedor, @total, GETDATE())

go

create procedure SP_LOGIN (@user varchar(100), @clave varchar(100), @results int output)
AS
BEGIN 
	SET NOCOUNT ON;
	IF exists(SELECT * FROM Clientes WHERE Cedula =@user AND Nombres =@clave)
			SET @results = 1
		ELSE
			SET @results = 0
	RETURN @results
END
	

--SELECT (SELECT DISTINCT TOP 1 Id FROM Compras ORDER BY Id DESC) + 1 AS Secuencial
select * from VentasDetalle
select * from ComprasDetalle
select * from Productos
select * from clientes

