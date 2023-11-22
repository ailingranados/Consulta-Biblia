--Ailin E. Granados Cantu
--12/11/2023
--Procedures para favoritos

CREATE PROCEDURE Biblia.SP_GuardarRef
@Id_Idioma	    SMALLINT,
@Id_Version	    SMALLINT,
@Id_Testamento	SMALLINT,
@Id_Libro	    SMALLINT,
@Id_Capitulo	SMALLINT,
@Id_Versiculo	SMALLINT
AS
BEGIN
SET NOCOUNT ON;
	-- Verificar si ya existe un registro con el mismo Id_Versiculo
    IF NOT EXISTS (
        SELECT 1
        FROM Biblia.ReferenciaBiblia
        WHERE 
		
		Id_Idioma		=	@Id_Idioma		AND
		Id_Version		=	@Id_Version		AND
		Id_Testamento	=	@Id_Testamento	AND
		Id_Libro		=	@Id_Libro		AND
		Id_Capitulo		=	@Id_Capitulo	AND
		Id_Versiculo	=	@Id_Versiculo	
    )
    BEGIN
        -- Si no existe, realizar la inserción
        INSERT INTO Biblia.ReferenciaBiblia (
            Id_Idioma,
            Id_Version,
            Id_Testamento, 
            Id_Libro, 
			Id_Capitulo,
            Id_Versiculo
        )
        VALUES (
            @Id_Idioma,
            @Id_Version,
            @Id_Testamento,
            @Id_Libro,
			@Id_Capitulo,
            @Id_Versiculo
        )
    END
END
GO

CREATE PROCEDURE Biblia.SP_BuscarRef
@Id_Idioma	    SMALLINT,
@Id_Version	    SMALLINT,
@Id_Testamento	SMALLINT,
@Id_Libro	    SMALLINT,
@Id_Capitulo	SMALLINT,
@Id_Versiculo	SMALLINT
AS 
BEGIN
SET NOCOUNT ON;

	SELECT 
	(Id_referencia)
		FROM 
		Biblia.ReferenciaBiblia
			WHERE
			Id_Idioma		=	@Id_Idioma		AND
			Id_Version		=	@Id_Version		AND
			Id_Testamento	=	@Id_Testamento	AND
			Id_Libro		=	@Id_Libro		AND
			Id_Capitulo		=	@Id_Capitulo	AND
			Id_Versiculo	=	@Id_Versiculo

END
GO
			
CREATE PROCEDURE Consultas.SP_GruardarFav
@Id_usuario		SMALLINT,
@Id_referencia	SMALLINT,
@Nombre			VARCHAR(15)
AS
BEGIN
SET NOCOUNT ON;
	
	INSERT INTO Consultas.Favorito 
	(Id_usuario, 
	 FechaFav, 
	 Id_referencia,
	 NombreFav)
			VALUES
			(@Id_usuario,
			GETDATE(),
			@Id_referencia,
			@Nombre)

END
GO

ALTER PROCEDURE Consultas.SP_BuscarFavUsuario
@Id_usuario	INT
AS
BEGIN
SET NOCOUNT ON
	SELECT NombreFav AS NOMBRE, FechaFav AS FECHA,
		IDIOMA, VERSIONES, TESTAMENTOS, LIBRO, NumeroCap AS CAPITULO, 
		VERSICULO, Id_favorito

		FROM 
		Biblia.V_FavoritosBiblia
			WHERE 
			Id_usuario = @Id_usuario
END
GO

ALTER PROCEDURE Consultas.SP_BuscarFavUsuarioCap
@Id_usuario	INT
AS
BEGIN
SET NOCOUNT ON
	SELECT 
	NombreFav,
	FechaFav, 
	IDIOMA,
	VERSIONES,
	TESTAMENTOS, 
	LIBRO,
	CAPITULO, 
	COUNT(*) AS NUM_VERSICULOS,
	Id_favorito,

	Id_Idioma, 
	Id_Version, 
	Id_Testamento, 
	Id_Libro, 
	
	Id_referencia, 
	Id_usuario
	
		FROM Biblia.V_FavoritosBibliaCapitulos
			WHERE 
				Id_usuario = @Id_usuario
			GROUP BY 
			NombreFav,
			FechaFav, 
			IDIOMA,
			VERSIONES,
			TESTAMENTOS, 
			LIBRO,
			CAPITULO, 
			Id_favorito,

			Id_Idioma, 
			Id_Version, 
			Id_Testamento, 
			Id_Libro, 
	
			Id_referencia, 
			Id_usuario

			HAVING COUNT(*) > 1 ;

	--SELECT 
	--	NombreFav, FechaFav, IDIOMA, VERSIONES, TESTAMENTOS, 
	--	LIBRO, CAPITULO, VERSICULO, id_favorito
		
	--	FROM 
	--	Biblia.V_FavoritosBibliaCapitulos
		
END
GO

CREATE PROCEDURE Biblia.SP_EncontrarRef
@id_referencia	SMALLINT

AS
BEGIN
SET NOCOUNT ON;
	SELECT 
	Id_Idioma, 
	Id_Version,
	Id_Testamento,
	Id_Libro,
	Id_Versiculo
		FROM 
		Biblia.ReferenciaBiblia
			WHERE 
			Id_referencia = @id_referencia

END
GO

ALTER PROCEDURE Biblia.SP_ConsultarBiblia
AS
BEGIN
SET NOCOUNT ON;
	SELECT IDIOMA, VERSIONES, 
	TESTAMENTOS, LIBRO, NumeroCap AS CAPITULO, VERSICULO, NumeroVers
	FROM Biblia.V_TextosBiblia
END
GO

CREATE PROCEDURE Consultas.SP_EliminarFav
@Id_favorito	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	DELETE FROM Consultas.Favorito
	WHERE Id_favorito = @Id_favorito
END
GO

ALTER PROCEDURE Biblia.SP_VersiculosEnCapitulo
@Id_idioma		SMALLINT,
@Id_version		SMALLINT,
@Id_testamento	SMALLINT,
@Id_libro		SMALLINT,
@Id_capitulo	SMALLINT
AS
BEGIN
SET NOCOUNT ON;
	SELECT VERSICULO
		FROM Biblia.V_TextosBiblia
			WHERE NumeroCap = @Id_capitulo AND
			Id_Idioma	=	@Id_idioma	AND
			Id_Version	=	@Id_version	AND
			Id_Testamento	=	@Id_testamento	AND
			Id_Libro	=	@Id_libro
END
GO






