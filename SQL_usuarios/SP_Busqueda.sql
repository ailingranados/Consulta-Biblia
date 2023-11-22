--Ailin E. Granados Cantu
--19/11/2023
--BUSQUEDA



ALTER PROCEDURE Consultas.SP_BusquedaPorPalabra
@Id_idioma		SMALLINT,
@Id_version		SMALLINT,
@Id_testamento	SMALLINT,
@Id_Libro		SMALLINT,
@palabras		varchar(30)

AS
BEGIN
	
	IF(@Id_testamento = 0 AND @Id_Libro = 0)
	BEGIN
		SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO, NumeroCap, NumeroVers, VERSICULO
			FROM Biblia.V_TextosBiblia
				WHERE EXISTS(
				SELECT 1
				FROM STRING_SPLIT(@palabras, ' ') AS palabra 
				WHERE VERSICULO LIKE '%' + palabra.value + '%'	OR
						LIBRO LIKE '%' + palabra.value + '%'	OR
						TESTAMENTOS LIKE '%' + palabra.value + '%'
				)	
		AND 
		Id_Idioma	=	@Id_idioma		AND
		Id_Version	=	@Id_version
	END
	ELSE IF (@Id_Libro = 0)
	BEGIN
		SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO, NumeroCap, NumeroVers, VERSICULO
			FROM Biblia.V_TextosBiblia
				WHERE EXISTS(
				SELECT 1
				FROM STRING_SPLIT(@palabras, ' ') AS palabra 
				WHERE VERSICULO LIKE '%' + palabra.value + '%'	OR
						LIBRO LIKE '%' + palabra.value + '%'
				)	
		AND 
		Id_Idioma		=	@Id_idioma		AND
		Id_Version		=	@Id_version		AND
		Id_Testamento	=	@Id_testamento
	END
	ELSE
	BEGIN
		SELECT IDIOMA, VERSIONES, TESTAMENTOS, LIBRO, NumeroCap, NumeroVers, VERSICULO
			FROM Biblia.V_TextosBiblia
				WHERE EXISTS(
				SELECT 1
				FROM STRING_SPLIT(@palabras, ' ') AS palabra 
				WHERE VERSICULO LIKE '%' + palabra.value + '%'
				)	
		AND 
		Id_Idioma		=	@Id_idioma		AND
		Id_Version		=	@Id_version		AND
		Id_Testamento	=	@Id_testamento	AND
		Id_Libro		=	 @Id_Libro
	END

END;
GO

--EXEC Consultas.SP_BusquedaPorPalabra 
--@Id_idioma=1, @Id_version=2, @Id_testamento=0, @Id_Libro=0, @palabras = 'antiguo';
--GO

ALTER PROCEDURE Consultas.SP_InsertarBusqueda
@Id_usuario		SMALLINT,
@palabras		varchar(30)
AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Consultas.Busqueda	(Texto, Id_usuario)
	VALUES (@palabras, @Id_usuario)

END
GO

CREATE TRIGGER Consultas.T_HistorialBusqueda
ON Consultas.Busqueda
AFTER INSERT
AS
BEGIN
	DECLARE @Id AS INT = (SELECT Id_busqueda FROM inserted)

	INSERT INTO Consultas.Historial(Texto, FechaBus, Busqueda)
	VALUES ('BUSQUEDA', GETDATE(), @Id)
END
GO


