--16-OCT-23
--Ailin Elizabeth Granados Cantu
--Creacion de tablas



CREATE DATABASE UsuariosBiblia

USE UsuariosBiblia

--*********************************************************************GENERO
CREATE TABLE Genero (
Id_genero	INT IDENTITY(1,1),
Descripcion	VARCHAR(20) default 'Sin Especificar',

CONSTRAINT PK_genero 
PRIMARY KEY (Id_genero)
)
SELECT * FROM Genero


--*********************************************************************ESTATUS
CREATE TABLE Estatus(
Id_estatus	INT			IDENTITY(1,1),
Descripcion	VARCHAR(20)	NOT NULL,

CONSTRAINT PK_estatus PRIMARY KEY (Id_estatus)
)
SELECT * FROM Estatus

--*********************************************************************USUARIO
CREATE TABLE Usuario (
Id_usuario	INT		IDENTITY (1, 1),
Id_Genero	INT,
Correo		VARCHAR (10)	NOT NULL,
Fecha_nac	DATETIME		CHECK(Fecha_nac < '2023-01-01'),
Nombre		VARCHAR(10)		NOT NULL,
ApellidoM	VARCHAR(10),
ApellidoP	VARCHAR(10)

CONSTRAINT	PK_usuario  PRIMARY KEY (Id_usuario),
CONSTRAINT	FK_genero	FOREIGN KEY	(Id_Genero) REFERENCES Genero(Id_genero)
)
SELECT * FROM Usuario

--*********************************************************************CONTRASEÑA
CREATE TABLE Contraseña(
Id_contraseña	INT				IDENTITY(1,1),
ConPrincipal	VARCHAR(20)		NOT NULL,
ConVieja1		VARCHAR(20),
ConVieja2		VARCHAR(20),
Id_usuario		INT,

CONSTRAINT PK_contraseña PRIMARY KEY (Id_contraseña),
CONSTRAINT FK_usuario FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario)
)
SELECT * FROM Contraseña

--*********************************************************************BUSQUEDA
CREATE TABLE Busqueda(
Id_busqueda	INT			IDENTITY(1,1),
Texto		VARCHAR(20) NOT NULL,
Fecha		DATETIME	NOT NULL,
Id_usuario	INT,

CONSTRAINT PK_busqueda PRIMARY KEY (Id_busqueda),
CONSTRAINT FK_usuarioB FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario)
)

SELECT * FROM Busqueda

--*********************************************************************FAVORITOS
CREATE TABLE Favorito(
Id_favorito	INT				IDENTITY(1,1),
Id_usuario	INT,
FechaFav	DATETIME	NOT NULL,

CONSTRAINT PK_favorito	PRIMARY KEY (Id_favorito),
CONSTRAINT FK_usuarioF	FOREIGN KEY (Id_usuario)	REFERENCES Usuario(Id_usuario)
)
SELECT * FROM Favorito

--*********************************************************************HISTORIAL
CREATE TABLE Historial(
Id_historial	INT			IDENTITY(1,1),
Texto			VARCHAR(20),
Id_busqueda		INT,
FechaBus		DATETIME,

CONSTRAINT PK_historial PRIMARY KEY (Id_historial)
)
SELECT * FROM Historial


--*********************************************************************CONSULTAS
CREATE TABLE Consulta (
Id_consulta	INT IDENTITY (1,1),
Consulta	VARCHAR(20)		NOT NULL,

CONSTRAINT PK_Consulta PRIMARY KEY (Id_consulta)
)
SELECT * FROM Consulta

--*********************************************************************HISCON
CREATE TABLE HistorialConsulta(
Id_HisCon		INT			IDENTITY(1,1),
Id_historial	INT,
Id_consulta		INT,

CONSTRAINT PK_HisCon PRIMARY KEY (Id_HisCon),
CONSTRAINT FK_historial FOREIGN KEY (Id_historial) REFERENCES Historial(Id_historial),
CONSTRAINT FK_consulta FOREIGN KEY (Id_consulta) REFERENCES Consulta(Id_consulta)
)
SELECT * FROM HistorialConsulta

--*********************************************************************FAVORICON CONSULTA
CREATE TABLE FavoritoConsulta(
Id_FavCon		INT IDENTITY(1,1),
Id_favorito		INT,
Id_consulta		INT,

CONSTRAINT PK_FavCon PRIMARY KEY (Id_FavCon),
CONSTRAINT FK_favorito FOREIGN KEY (Id_favorito) REFERENCES Favorito(Id_favorito),
CONSTRAINT FK_consultaF FOREIGN KEY (Id_consulta) REFERENCES Consulta(Id_consulta)
)
SELECT * FROM FavoritoConsulta

--*********************************************************************USUARIO ESTATUS
CREATE TABLE UsuarioEstatus (
Id_UsEst	INT			IDENTITY (1,1),
FechaReg	DATETIME,
FechaBaja	DATETIME,

Id_estatus	INT,
Id_usuario	INT,

CONSTRAINT PK_UsEst PRIMARY KEY (Id_UsEst),
CONSTRAINT FK_estatusU FOREIGN KEY (Id_estatus) REFERENCES Estatus(Id_estatus),
CONSTRAINT FK_usuarioE FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario)
)
SELECT * FROM UsuarioEstatus