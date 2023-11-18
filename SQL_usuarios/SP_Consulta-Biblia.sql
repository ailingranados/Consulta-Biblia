--Ailin E. Granados Cantu
--11/11/2023
--Procedures para consultar biblia

USE DB_Usuarios
GO



CREATE PROCEDURE Biblia.SP_IdiomasBiblia
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Idioma, Nombre
		FROM 
		DB_Bible.dbo.Idiomas

END
GO

CREATE PROCEDURE Biblia.SP_BuscarIdioma
@Nombre		VARCHAR(20)
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Idioma
		FROM 
		DB_Bible.dbo.Idiomas
			WHERE 
			Nombre = @Nombre

END
GO

CREATE PROCEDURE Biblia.SP_BuscarIdiomaPorId
@id		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Nombre
		FROM 
		DB_Bible.dbo.Idiomas
			WHERE 
			Id_Idioma = @id

END
GO

CREATE PROCEDURE Biblia.SP_VersionBiblia
@Id_idioma	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Version, NombreVersion, SiglasVersion, Traductor, FechaVersion, Id_Idioma
		FROM 
		DB_Bible.dbo.Versiones
			WHERE Id_Idioma = @Id_idioma 
END
GO

CREATE PROCEDURE Biblia.SP_BuscarVersion
@Nombre		VARCHAR(30)
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Version
		FROM 
		DB_Bible.dbo.Versiones
			WHERE 
			NombreVersion = @Nombre

END
GO

CREATE PROCEDURE Biblia.SP_BuscarVersionPorId
@id		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	NombreVersion
		FROM 
		DB_Bible.dbo.Versiones
			WHERE 
			Id_Version = @id

END
GO

CREATE PROCEDURE Biblia.SP_TestamentosBiblia
@Id_idioma	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Testamento, Nombre, OrdenTest, Id_Idioma
		FROM 
		DB_Bible.dbo.Testamentos
			WHERE 
			Id_Idioma = @Id_idioma
END
GO

CREATE PROCEDURE Biblia.SP_BuscarTestamento
@Nombre		VARCHAR(20)
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Testamento
		FROM 
		DB_Bible.dbo.Testamentos
			WHERE 
			Nombre = @Nombre

END
GO

CREATE PROCEDURE Biblia.SP_BuscarTestamentoPorId
@id		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Nombre
		FROM 
		DB_Bible.dbo.Testamentos
			WHERE 
			Id_Testamento = @id

END
GO

CREATE PROCEDURE Biblia.SP_LibrosBiblia
@Id_idioma		SMALLINT,
@Id_testamento	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Libro, nombre, OrdenLibro, CapitulosTot, Autor, Año, Id_Testamento, Id_Idioma
		FROM 
		DB_Bible.dbo.Libros
			WHERE 
			Id_Idioma		=	@Id_idioma		AND
			Id_Testamento	=	@Id_testamento
END
GO

CREATE PROCEDURE Biblia.SP_BuscarLibro
@Nombre		VARCHAR(20)
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Libro
		FROM 
		DB_Bible.dbo.Libros
			WHERE 
			Nombre = @Nombre

END
GO

CREATE PROCEDURE Biblia.SP_BuscarLibroPorId
@id		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Nombre
		FROM 
		DB_Bible.dbo.Libros
			WHERE 
			Id_Libro = @id

END
GO

ALTER PROCEDURE Biblia.SP_CapitulosBiblia

@Id_version		SMALLINT,
@Id_libro		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
    Id_Version, Id_Libro, NumeroCap, MIN(NumeroVers) AS MinVersiculo, MAX(NumeroVers) AS MaxVersiculo
	FROM 
		DB_Bible.dbo.Versiculos
	WHERE
			Id_Version	=	@Id_version AND
			Id_Libro	=	@Id_libro
	GROUP BY
		Id_Version, Id_Libro, NumeroCap;		
END
GO


CREATE PROCEDURE Biblia.SP_VersiculosBiblia

@Id_version		SMALLINT,
@Id_libro		SMALLINT,
@Id_capitulo	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Id_Version, Id_Libro, NumeroCap, NumeroVers, Texto, Id_Vers
		FROM 
		DB_Bible.dbo.Versiculos
			WHERE
			Id_Version	=	@Id_version AND
			Id_Libro	=	@Id_libro	AND
			NumeroCap	=	@Id_capitulo
			
END
GO

ALTER PROCEDURE Biblia.SP_BuscarVersiculo
@IDIOMA		SMALLINT,
@VERSION	SMALLINT,
@TESTAMENTO	SMALLINT,
@LIBRO		SMALLINT,
@NumVer		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	NumeroVers
		FROM 
		Biblia.V_TextosBiblia
			WHERE 
			
			Id_Idioma = @IDIOMA AND
			Id_Version = @VERSION AND
			Id_Testamento = @TESTAMENTO AND
			Id_Libro = @LIBRO AND
			NumeroVers = @NumVer

END
GO

CREATE PROCEDURE Biblia.SP_BuscarVersiculoPorId
@id		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT 
	Texto
		FROM 
		DB_Bible.dbo.Versiculos
			WHERE 
			Id_Vers = @id

END
GO

ALTER PROCEDURE Biblia.SP_Consulta_IV
@Id_idioma		SMALLINT,
@Id_version		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	--SELECT I.Nombre, V.NombreVersion, T.Nombre, L.Nombre, VE.NumeroVers, VE.Texto
	--	FROM
	--		DB_Bible.dbo.Idiomas I
	--		INNER JOIN DB_Bible.dbo.Versiones V		ON	V.Id_Idioma = @Id_idioma
	--		INNER JOIN DB_Bible.dbo.Testamentos T	ON	T.Id_Idioma = @Id_idioma
	--		INNER JOIN DB_Bible.dbo.Libros L		ON	L.Id_Idioma = @Id_idioma
	--		INNER JOIN DB_Bible.dbo.Versiculos VE	ON	VE.Id_Version = @Id_version
	SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO,NumeroCap AS CAPITULO, NumeroVers AS NUMERO, VERSICULO
	FROM Biblia.V_TextosBiblia
		WHERE 
		Id_Idioma		=	@Id_idioma	AND
		Id_Version	=	@Id_version;

END
GO


ALTER PROCEDURE Biblia.SP_Consulta_IVT
@Id_idioma		SMALLINT,
@Id_version		SMALLINT,
@Id_testamento	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO,NumeroCap AS CAPITULO, NumeroVers AS NUMERO, VERSICULO
	FROM Biblia.V_TextosBiblia

		WHERE 
		Id_Idioma		=	@Id_idioma	AND
		Id_Version	=	@Id_version	AND
		Id_Testamento	=	@Id_testamento;

END
GO

ALTER PROCEDURE Biblia.SP_Consulta_IVTL
@Id_idioma		SMALLINT,
@Id_version		SMALLINT,
@Id_testamento	SMALLINT,
@Id_libro		SMALLINT
AS
BEGIN
SET NOCOUNT ON;
	SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO,NumeroCap AS CAPITULO, NumeroVers AS NUMERO, VERSICULO
	FROM Biblia.V_TextosBiblia

		WHERE 
		Id_Idioma		=	@Id_idioma	AND
		Id_Version	=	@Id_version	AND
		Id_Testamento	=	@Id_testamento	AND
		Id_Libro		=	@Id_libro;

END
GO

ALTER PROCEDURE Biblia.SP_Consulta_IVTLVE
@Id_idioma		SMALLINT,
@Id_version		SMALLINT,
@Id_testamento	SMALLINT,
@Id_libro		SMALLINT,
@Id_capitulo	SMALLINT,
@Id_versiculo	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

--PONERLE I.NOMBRE AS IDIOMA
SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO,NumeroCap AS CAPITULO, NumeroVers AS NUMERO, VERSICULO
	FROM Biblia.V_TextosBiblia
		WHERE 
		Id_Idioma		=	@Id_idioma	AND
		Id_Version	=	@Id_version	AND
		Id_Testamento	=	@Id_testamento	AND
		Id_Libro		=	@Id_libro		AND
		NumeroCap		=	@Id_capitulo	AND
		NumeroVers		=	@Id_versiculo;

END
GO

CREATE PROCEDURE Biblia.SP_Consulta_IVTLC
@Id_idioma		SMALLINT,
@Id_version		SMALLINT,
@Id_testamento	SMALLINT,
@Id_libro		SMALLINT,

@Id_capitulo	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

--PONERLE I.NOMBRE AS IDIOMA
SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO,NumeroCap AS CAPITULO, NumeroVers AS NUMERO, VERSICULO
	FROM Biblia.V_TextosBiblia
		WHERE 
		Id_Idioma		=	@Id_idioma	AND
		Id_Version	=	@Id_version	AND
		Id_Testamento	=	@Id_testamento	AND
		Id_Libro		=	@Id_libro		AND
		NumeroCap		= @Id_capitulo

END
GO

SELECT * FROM Consultas.Favorito
SELECT * FROM Biblia.ReferenciaBiblia
EXEC Biblia.SP_Consulta_IV 1, 2

EXEC Biblia.SP_BuscarVersiculo 1, 2, 1, 1, 2