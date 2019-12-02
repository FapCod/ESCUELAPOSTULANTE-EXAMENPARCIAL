create database ESCUELAPOSTULANTE
USE ESCUELAPOSTULANTE
----CreacionDeTablaEscuela-----------
CREATE TABLE escuela(
codEscuela int primary key not null ,
nombreEscuela varchar(30) not null,
vacanteEscuela int not null,
inscritoEscuela int,
estadoEscuela bit
)
--------------------------------------
-----InsertarDatos---------
INSERT INTO escuela VALUES('12345','Medicina',25,1,1)
SELECT * FROM escuela

----CreacionDeTablaPostulante-----------
CREATE TABLE postulante(
codPostulante int primary key not null,
nombrePostulante varchar(30) not null,
apellidoPostulante varchar(30) not null,
codEscuela int ,
direccionPostulante varchar(30) not null,
telefonoPostulante char(9) not null,
fechanacimientoPostulante date,
sexoPostulante char(1)
CONSTRAINT fk_escuela FOREIGN KEY (codEscuela) REFERENCES escuela (codEscuela)
)
------------------------------------------------------------------------------
---InsertarDatos--------
INSERT INTO postulante VALUES(123,'Frank Antonio','Piñin Ato',1,'Santa rosa jr puno 249','987654321','1999/10/01 ','M')
SELECT * FROM postulante

-----CREAMOS LOS PROCEDIMIENTOS ALMACENADOS PARA ESCUELA------- 
------------------------------------------------------------------------------------------------------
------------Procedimiento almacenado para registrar una escuela--------------------------

create procedure registrarEscuela(
@codEscuela int,
@nombreEscuela varchar(30),
@vacanteEscuela int,
@inscritoEscuela int ,
@estadoEscuela bit
)
as 
begin 
insert into escuela values (@codEscuela, @nombreEscuela, @vacanteEscuela, @inscritoEscuela, @estadoEscuela )
end 

----Fin del procedimiento almacenado---------------------------

---Procedimiento almacenado para Actualizar una Escuela----
create procedure actualizarEscuela(
@codEscuela int,
@nombreEscuela varchar(30),
@vacanteEscuela int,
@inscritoEscuela int ,
@estadoEscuela bit
)
as 
begin 
update escuela set nombreEscuela= @nombreEscuela, vacanteEscuela= @vacanteEscuela, inscritoEscuela= @inscritoEscuela, estadoEscuela= @estadoEscuela
where codEscuela = @codEscuela
end

----Fin del procedimiento almacenado----


---Procedimiento almacenado para Eliminar una escuela----
create procedure eliminarEscuela (
@codEscuela int
)
as
begin
delete from escuela where codEscuela= @codEscuela
end
----Fin del procedimiento almacenado------

---Procedimiento almacenado para Buscar una Escuela----
create procedure buscarEscuela (
@codEscuela int
)
as
begin
select * from escuela where codEscuela = @codEscuela
end
---Fin del procedimiento almacenado----

---Procedimiento almacenado para Listar escuelas activas----
create procedure listarEscuela
as
begin 
select * from escuela where estadoEscuela = '1' 
end
-----Fin del procedimiento-------------------------------------


------------------------------------POSTULANTE
-----CREAMOS LOS PROCEDIMIENTOS ALMACENADOS PARA POSTULANTES------- 
-----------------------------------------------------------------------------------------------------
--------------Procedimiento almacenado para registrar un postulante------------------------

create procedure registrarPostulante(
@codPostulante int,
@nombrePostulante varchar(30),
@apellidoPostulante  varchar(30),
@codEscuela int ,
 @direccionPostulante  varchar(30),
 @telefonoPostulante char(9), 
 @fechanacimientoPostulante date, 
 @sexoPostulante char(1)
)
as 
begin 
insert into postulante values ( @codPostulante, @nombrePostulante, @apellidoPostulante, @codEscuela, @direccionPostulante, @telefonoPostulante, @fechanacimientoPostulante	, @sexoPostulante)
end 
----Fin del procedimiento almacenado-----

---Procedimiento almacenado para Actualizar un postulante----
create procedure actualizarPostulante(
@codPostulante int,
@nombrePostulante varchar(30),
@apellidoPostulante varchar(30),
@codEscuela int ,
 @direccionPostulante  varchar(30),
 @telefonoPostulante char(9), 
 @fechanacimientoPostulante date, 
 @sexoPostulante char(1)
)
as 
begin 
update postulante set  nombrePostulante = @nombrePostulante, apellidoPostulante = @apellidoPostulante, codEscuela = @codEscuela, direccionPostulante = @direccionPostulante, telefonoPostulante =  @telefonoPostulante, fechanacimientoPostulante =  @fechanacimientoPostulante	, sexoPostulante = @sexoPostulante
where codPostulante = @codPostulante
end
----Fin del procedimiento almacenado----


---Procedimiento almacenado para Eliminar un postulante----
create procedure eliminarPostulante (
@codPostulante int
)
as
begin
delete from postulante where codPostulante = @codPostulante
end
----Fin del procedimiento almacenado------

---Procedimiento almacenado para Buscar un postulante----
create procedure buscarPostulante (
@codPostulante int
)
as
begin
select * from postulante where codPostulante = @codPostulante
end
---Fin del procedimiento almacenado----

---Procedimiento almacenado para listar los postulantes----
create procedure listarPostulante
as 
begin 
SELECT dbo.postulante.codPostulante, dbo.postulante.nombrePostulante, dbo.postulante.apellidoPostulante, dbo.escuela.nombreEscuela, dbo.postulante.direccionPostulante, dbo.postulante.telefonoPostulante, 
                  dbo.postulante.fechanacimientoPostulante, dbo.postulante.sexoPostulante
FROM     dbo.escuela INNER JOIN
                  dbo.postulante ON dbo.escuela.codEscuela = dbo.postulante.codEscuela
end


-----fin del procedimiento almacenado 