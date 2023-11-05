--16-OCT-23
--Ailin Elizabeth Granados Cantu
--Creacion de tablas

CREATE DATABASE DB_Usuarios

USE DB_Usuarios
GO
--Crear los esquemas

CREATE SCHEMA Usuario;
GO

CREATE SCHEMA Consultas;
GO

CREATE SCHEMA Relaciones;
GO

CREATE SCHEMA Biblia;
GO

--*******************************************************ReferenciaBiblia***********************************************
CREATE TABLE Biblia.ReferenciaBiblia (

Id_referencia	SMALLINT			NOT NULL		IDENTITY(1,1),
Id_Idioma	    SMALLINT,
Id_Version	    SMALLINT,
Id_Testamento	SMALLINT,
Id_Libro	    SMALLINT,
Id_Versiculo	SMALLINT,

CONSTRAINT		PK_genero 
PRIMARY KEY		(Id_referencia),

)

SELECT * FROM Biblia.ReferenciaBiblia

--********************************************************GENERO********************************************************

CREATE TABLE Usuario.Genero (

Id_genero		TINYINT			NOT NULL		IDENTITY(1,1),
Descripcion		VARCHAR(20) 
				DEFAULT			 'Sin Especificar',

CONSTRAINT		PK_genero 
PRIMARY KEY		(Id_genero)
	
)

SELECT * FROM Usuario.Genero



--*******************************************************ESTATUS********************************************************

CREATE TABLE Usuario.Estatus(

Id_estatus		TINYINT			NOT NULL		IDENTITY(1,1),
Descripcion		VARCHAR(10)		NOT NULL,

CHECK			(Descripcion =	 'Activo'
				OR Descripcion = 'Inactivo'),

CONSTRAINT		PK_estatus 
PRIMARY KEY		(Id_estatus)

)

SELECT * FROM Usuario.Estatus

--*******************************************************USUARIO********************************************************

CREATE TABLE Usuario.UsuarioRegistros (

Id_usuario		SMALLINT		NOT NULL		IDENTITY (1, 1),
Id_Genero		TINYINT,
Correo			VARCHAR (20)	NOT NULL,
Fecha_nac		DATETIME		NOT NULL,
Nombre			VARCHAR(10)		NOT NULL,
ApellidoM		VARCHAR(10),
ApellidoP		VARCHAR(10)		NOT NULL,

CHECK			(Fecha_nac < '2023-01-01'),

CONSTRAINT		PK_usuario
PRIMARY KEY	    (Id_usuario),

CONSTRAINT		FK_genero	
FOREIGN KEY		(Id_Genero) 
REFERENCES		Usuario.Genero(Id_genero)

)

SELECT * FROM Usuario.UsuarioRegistros


--*******************************************************Contraseña********************************************************

CREATE TABLE Usuario.Contraseña(

Id_contraseña	SMALLINT		NOT NULL		IDENTITY(1,1),
ConVieja1		VARCHAR(20),
ConVieja2		VARCHAR(20),

CONSTRAINT		PK_contraseña 
PRIMARY KEY		(Id_contraseña),

)

SELECT * FROM Usuario.Contraseña


--*******************************************************Busqueda********************************************************

CREATE TABLE Consultas.Busqueda(
Id_busqueda		SMALLINT			NOT NULL		IDENTITY(1,1),
Texto			VARCHAR(20)			NOT NULL,
Fecha			DATETIME			NOT NULL,
Id_usuario		SMALLINT,
Id_referencia	SMALLINT,

CONSTRAINT		PK_busqueda 
PRIMARY KEY		(Id_busqueda),

CONSTRAINT		FK_usuarioB 
FOREIGN KEY		(Id_usuario) 
REFERENCES		Usuario.UsuarioRegistros(Id_usuario),

CONSTRAINT		FK_referenciaB 
FOREIGN KEY		(Id_referencia) 
REFERENCES		Biblia.ReferenciaBiblia(Id_referencia)
)

SELECT * FROM Consultas.Busqueda

--*******************************************************Favorito********************************************************

CREATE TABLE Consultas.Favorito(
Id_favorito		SMALLINT	NOT NULL				IDENTITY(1,1),
Id_usuario		SMALLINT	NOT NULL,
FechaFav		DATETIME	NOT NULL,
Id_referencia	SMALLINT,

CONSTRAINT		PK_favorito	
PRIMARY KEY		(Id_favorito),

CONSTRAINT		FK_usuarioF	
FOREIGN KEY		(Id_usuario)	
REFERENCES		Usuario.UsuarioRegistros(Id_usuario),

CONSTRAINT		FK_referenciaF 
FOREIGN KEY		(Id_referencia) 
REFERENCES		Biblia.ReferenciaBiblia(Id_referencia)
)

SELECT * FROM Consultas.Favorito

--*******************************************************Historial********************************************************

CREATE TABLE Consultas.Historial(

Id_historial	SMALLINT	NOT NULL			IDENTITY(1,1),
Texto			VARCHAR(20),
Id_busqueda		SMALLINT,
FechaBus		DATETIME	NOT NULL,
Id_referencia	SMALLINT,

CONSTRAINT		PK_historial 
PRIMARY KEY		(Id_historial),

CONSTRAINT		FK_busqueda	
FOREIGN KEY		(Id_busqueda)	
REFERENCES		Consultas.Busqueda(Id_busqueda),

CONSTRAINT		FK_referenciaH 
FOREIGN KEY		(Id_referencia) 
REFERENCES		Biblia.ReferenciaBiblia(Id_referencia)
)

SELECT * FROM Consultas.Historial

--*******************************************************Consulta********************************************************

CREATE TABLE Consultas.Consulta (

Id_consulta		SMALLINT		NOT NULL			IDENTITY (1,1),
Consulta		VARCHAR(20)		NOT NULL,
Id_referencia	SMALLINT,

CONSTRAINT		PK_Consulta 
PRIMARY KEY		(Id_consulta),

CONSTRAINT		FK_referenciaC 
FOREIGN KEY		(Id_referencia) 
REFERENCES		Biblia.ReferenciaBiblia(Id_referencia)
)

SELECT * FROM Consultas.Consulta


--*******************************************************Historial Consulta***********************************************

CREATE TABLE Relaciones.HistorialConsulta(

Id_HisCon		SMALLINT	NOT NULL			IDENTITY(1,1),
Id_historial	SMALLINT	NOT NULL,
Id_consulta		SMALLINT	NOT NULL,

CONSTRAINT		PK_HisCon 
PRIMARY KEY		(Id_HisCon),

CONSTRAINT		FK_historial 
FOREIGN KEY		(Id_historial) 
REFERENCES		Consultas.Historial(Id_historial),

CONSTRAINT		FK_consulta 
FOREIGN KEY		(Id_consulta) 
REFERENCES		Consultas.Consulta(Id_consulta)
)

SELECT * FROM Relaciones.HistorialConsulta

--*******************************************************Favorito Consulta***********************************************

CREATE TABLE Relaciones.FavoritoConsulta(

Id_FavCon		SMALLINT	NOT NULL		IDENTITY(1,1),
Id_favorito		SMALLINT	NOT NULL,
Id_consulta		SMALLINT	NOT NULL,

CONSTRAINT		PK_FavCon 
PRIMARY KEY		(Id_FavCon),

CONSTRAINT		FK_favorito 
FOREIGN KEY		(Id_favorito) 
REFERENCES		Consultas.Favorito(Id_favorito),

CONSTRAINT		FK_consultaF 
FOREIGN KEY		(Id_consulta) 
REFERENCES		Consultas.Consulta(Id_consulta)
)

SELECT * FROM Relaciones.FavoritoConsulta

--*******************************************************Usuario Estatus***********************************************

CREATE TABLE Relaciones.UsuarioEstatus (

Id_UsEst		SMALLINT	NOT NULL		IDENTITY (1,1),
FechaReg		DATETIME,
FechaBaja		DATETIME,

Id_estatus		TINYINT		NOT NULL,
Id_usuario		SMALLINT	NOT NULL,

CONSTRAINT		PK_UsEst 
PRIMARY KEY		(Id_UsEst),

CONSTRAINT		FK_estatusU 
FOREIGN KEY		(Id_estatus) 
REFERENCES		Usuario.Estatus(Id_estatus),

CONSTRAINT		FK_usuarioE 
FOREIGN KEY		(Id_usuario) 
REFERENCES		Usuario.UsuarioRegistros(Id_usuario)

)

SELECT * FROM Relaciones.UsuarioEstatus
