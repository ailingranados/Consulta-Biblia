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
