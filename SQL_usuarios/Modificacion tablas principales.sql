--Ailin E.Granados Cantu
--ALTER TABLES 
--modificacion de tablas principales
--04-11-23


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

   --DROP TABLE Usuario.Genero


   --DROP TABLE Usuario.Contraseña
GO

ALTER TABLE Usuario.Contraseña
ADD ConNueva VARCHAR(10) NOT NULL
GO

ALTER TABLE Usuario.Contraseña
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

ALTER TABLE Consultas.Favorito
ADD Consulta SMALLINT,
CONSTRAINT		FK_consulta	
FOREIGN KEY		(Consulta) 
REFERENCES		Consultas.Consulta(Id_consulta)
GO

ALTER TABLE Consultas.Favorito
ADD Id_referencia SMALLINT,
CONSTRAINT		FK_referenciaF	
FOREIGN KEY		(Id_referencia) 
REFERENCES		Biblia.ReferenciaBiblia(Id_referencia)
GO

ALTER TABLE Consultas.Consulta
ADD Historial SMALLINT,
CONSTRAINT		FK_historial
FOREIGN KEY		(Historial) 
REFERENCES		Consultas.Historial(Id_historial)
GO

ALTER TABLE Consultas.Consulta
DROP COLUMN Historial

ALTER TABLE Consultas.Consulta
DROP CONSTRAINT FK_historial


ALTER TABLE Consultas.Historial
DROP COLUMN Usuario

ALTER TABLE Consultas.Historial
DROP CONSTRAINT FK_usuarioH

ALTER TABLE Consultas.Consulta
DROP COLUMN Consulta
GO

ALTER TABLE Consultas.Consulta
ADD Id_usuario SMALLINT,
CONSTRAINT		FK_usuarioC
FOREIGN KEY		(Id_usuario) 
REFERENCES		Usuario.UsuarioRegistros(Id_usuario)
GO

ALTER TABLE Consultas.Busqueda
ADD Id_usuario SMALLINT,
CONSTRAINT		FK_usuarioB
FOREIGN KEY		(Id_usuario) 
REFERENCES		Usuario.UsuarioRegistros(Id_usuario)
GO

ALTER TABLE Usuario.UsuarioRegistros
DROP COLUMN Contraseñas;
GO

ALTER TABLE Consultas.Busqueda
DROP COLUMN Id_usuario
GO

ALTER TABLE Consultas.Busqueda
DROP CONSTRAINT FK_usuarioB

ALTER TABLE Consultas.Busqueda
ADD Historial SMALLINT,
CONSTRAINT		FK_historialB
FOREIGN KEY		(Historial) 
REFERENCES		Consultas.Historial(Id_historial)
GO


ALTER TABLE Consultas.Historial
ADD Usuario SMALLINT,
CONSTRAINT		FK_usuarioH
FOREIGN KEY		(Usuario) 
REFERENCES		Usuario.UsuarioRegistros(Id_usuario)
GO

ALTER TABLE Consultas.Historial
ADD Busqueda SMALLINT,
CONSTRAINT		FK_busquedaH
FOREIGN KEY		(Busqueda) 
REFERENCES		Consultas.Busqueda(Id_busqueda)
GO

ALTER TABLE Consultas.Historial
ADD Consulta SMALLINT,
CONSTRAINT		FK_consultaH
FOREIGN KEY		(Consulta) 
REFERENCES		Consultas.Consulta(Id_consulta)
GO