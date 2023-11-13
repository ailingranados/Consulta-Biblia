--Ailin E. Granados Cantu
--12/11/2023
--Procedures para favoritos


CREATE PROCEDURE Biblia.SP_GuardarRef
@Id_Idioma	    SMALLINT,
@Id_Version	    SMALLINT,
@Id_Testamento	SMALLINT,
@Id_Libro	    SMALLINT,
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
		Id_Versiculo	=	@Id_Versiculo	
    )
    BEGIN
        -- Si no existe, realizar la inserción
        INSERT INTO Biblia.ReferenciaBiblia (
            Id_Idioma,
            Id_Version,
            Id_Testamento, 
            Id_Libro, 
            Id_Versiculo
        )
        VALUES (
            @Id_Idioma,
            @Id_Version,
            @Id_Testamento,
            @Id_Libro,
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
			Id_Versiculo	=	@Id_Versiculo

END
GO
			
CREATE PROCEDURE Consultas.SP_GruardarFav
@Id_usuario		SMALLINT,
@Id_referencia	SMALLINT

AS
BEGIN
SET NOCOUNT ON;
	
	INSERT INTO Consultas.Favorito 
	(Id_usuario, 
	 FechaFav, 
	 Id_referencia)
			VALUES
			(@Id_usuario,
			GETDATE(),
			@Id_referencia)

END
GO

CREATE PROCEDURE Consultas.SP_BuscarFavUsuario
@Id_usuario	INT
AS
BEGIN
SET NOCOUNT ON
	SELECT 
	FechaFav, Id_referencia
		FROM 
		Consultas.Favorito
			WHERE 
			Id_usuario = @Id_usuario
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


--EXEC Biblia.SP_GuardarRef 1, 2, 1, 1, 4

SELECT * FROM Consultas.Favorito
SELECT * FROM Biblia.ReferenciaBiblia
SELECT * FROM Usuario.UsuarioRegistros

