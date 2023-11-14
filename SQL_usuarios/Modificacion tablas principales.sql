--Ailin E.Granados Cantu
--ALTER TABLES 
--modificacion de tablas principales
--04-11-23

ALTER TABLE Usuario.UsuarioRegistros
ADD Contraseņas SMALLINT,
CONSTRAINT		FK_contraseņa	
FOREIGN KEY		(Contraseņas) 
REFERENCES		Usuario.Contraseņa(Id_contraseņa)


ALTER TABLE Usuario.UsuarioRegistros
ADD Clave VARCHAR(10) NOT NULL

ALTER TABLE Usuario.UsuarioRegistros
DROP COLUMN clave

ALTER TABLE Usuario.UsuarioRegistros
DROP CONSTRAINT FK_genero;
GO

ALTER TABLE Usuario.UsuarioRegistros 
   ADD CONSTRAINT FK_genero
   FOREIGN KEY (Id_Genero) 
   REFERENCES Usuario.Genero(Id_genero);

   DROP TABLE Usuario.Genero


   DROP TABLE Usuario.Contraseņa
GO

ALTER TABLE Usuario.Contraseņa
ADD ConNueva VARCHAR(10) NOT NULL
GO

ALTER TABLE Usuario.Contraseņa
	ADD Id_usuario	SMALLINT,
	CONSTRAINT FK_usuario
	FOREIGN KEY (Id_usuario) 
    REFERENCES Usuario.UsuarioRegistros(Id_usuario)
GO

ALTER TABLE Usuario.UsuarioRegistros ALTER COLUMN Correo VARCHAR(40);  
GO  

ALTER TABLE Consultas.Favorito
ADD NombreFav VARCHAR(15)
GO

select * from Biblia.ReferenciaBiblia

ALTER TABLE Biblia.ReferenciaBiblia
ADD Id_Capitulo SMALLINT
GO

