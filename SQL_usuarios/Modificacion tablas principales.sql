--Ailin E.Granados Cantu
--ALTER TABLES 
--modificacion de tablas principales
--04-11-23

ALTER TABLE Usuario.UsuarioRegistros
ADD Contrase�as SMALLINT,
CONSTRAINT		FK_contrase�a	
FOREIGN KEY		(Contrase�as) 
REFERENCES		Usuario.Contrase�a(Id_contrase�a)


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


   DROP TABLE Usuario.Contrase�a
GO

ALTER TABLE Usuario.Contrase�a
ADD ConNueva VARCHAR(10) NOT NULL
GO

ALTER TABLE Usuario.Contrase�a
	ADD Id_usuario	SMALLINT,
	CONSTRAINT FK_usuario
	FOREIGN KEY (Id_usuario) 
    REFERENCES Usuario.UsuarioRegistros(Id_usuario)
GO

ALTER TABLE Usuario.UsuarioRegistros ALTER COLUMN Correo VARCHAR(40);  
GO  