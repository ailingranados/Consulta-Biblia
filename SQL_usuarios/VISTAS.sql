--Ailin E. Granados Cantu
--12/11/2023
--Vistas del proyecto

SELECT * FROM Biblia.V_TextosBibliaGOCREATE VIEW Biblia.V_TextosBiblia
AS
		SELECT 
    I.Id_Idioma,
    I.Nombre AS IDIOMA,
    V.Id_Version,
    V.NombreVersion AS VERSIONES,
    T.Id_Testamento,
    T.Nombre AS TESTAMENTOS,
    L.Id_Libro,
    L.Nombre AS LIBRO,
    VE.NumeroCap, 
    VE.NumeroVers, 
    VE.Texto AS VERSICULO
FROM 
    DB_Bible.dbo.Idiomas I
LEFT OUTER JOIN 
    DB_Bible.dbo.Versiones V ON I.Id_Idioma = V.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Testamentos T ON I.Id_Idioma = T.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Libros L ON I.Id_Idioma = L.Id_Idioma AND T.Id_Testamento = L.Id_Testamento
LEFT JOIN 
    DB_Bible.dbo.Versiculos VE ON V.Id_Version = VE.Id_Version AND L.Id_Libro = VE.Id_Libro;
GO

CREATE VIEW Biblia.V_ReferenciaBiblia
AS
		SELECT 
    I.Id_Idioma,
    I.Nombre AS IDIOMA,
    V.Id_Version,
    V.NombreVersion AS VERSIONES,
    T.Id_Testamento,
    T.Nombre AS TESTAMENTOS,
    L.Id_Libro,
    L.Nombre AS LIBRO,
    VE.NumeroCap, 
    VE.NumeroVers, 
    VE.Texto AS VERSICULO,
	B.Id_referencia
FROM 
    DB_Bible.dbo.Idiomas I
LEFT OUTER JOIN 
    DB_Bible.dbo.Versiones V ON I.Id_Idioma = V.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Testamentos T ON I.Id_Idioma = T.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Libros L ON I.Id_Idioma = L.Id_Idioma AND T.Id_Testamento = L.Id_Testamento
LEFT JOIN 
    DB_Bible.dbo.Versiculos VE ON V.Id_Version = VE.Id_Version AND L.Id_Libro = VE.Id_Libro

LEFT JOIN 
	Biblia.ReferenciaBiblia	B ON  B.Id_Idioma = I.Id_Idioma	AND
									B.Id_Version = V.Id_Version AND
									B.Id_Testamento = T.Id_Testamento AND
									B.Id_Libro = L.Id_Libro AND
									B.Id_Versiculo = VE.Id_Vers
									
	
GO

CREATE VIEW Biblia.V_FavoritosBiblia
AS
		SELECT 
    I.Id_Idioma,
    I.Nombre AS IDIOMA,
    V.Id_Version,
    V.NombreVersion AS VERSIONES,
    T.Id_Testamento,
    T.Nombre AS TESTAMENTOS,
    L.Id_Libro,
    L.Nombre AS LIBRO,
    VE.NumeroCap, 
    VE.NumeroVers, 
    VE.Texto AS VERSICULO,
	B.Id_referencia,
	F.Id_usuario,
	F.FechaFav,
	F.Id_favorito
FROM 
    DB_Bible.dbo.Idiomas I
LEFT OUTER JOIN 
    DB_Bible.dbo.Versiones V ON I.Id_Idioma = V.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Testamentos T ON I.Id_Idioma = T.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Libros L ON I.Id_Idioma = L.Id_Idioma AND T.Id_Testamento = L.Id_Testamento
LEFT JOIN 
    DB_Bible.dbo.Versiculos VE ON V.Id_Version = VE.Id_Version AND L.Id_Libro = VE.Id_Libro

LEFT JOIN 
	Biblia.ReferenciaBiblia	B ON  B.Id_Idioma = I.Id_Idioma	AND
									B.Id_Version = V.Id_Version AND
									B.Id_Testamento = T.Id_Testamento AND
									B.Id_Libro = L.Id_Libro AND
									B.Id_Versiculo = VE.Id_Vers

LEFT JOIN 
	Consultas.Favorito	F	ON	F.Id_referencia = B.Id_referencia;
	
GO

ALTER VIEW Biblia.V_FavoritosBiblia
AS
		SELECT 
    I.Id_Idioma,
    I.Nombre AS IDIOMA,
    V.Id_Version,
    V.NombreVersion AS VERSIONES,
    T.Id_Testamento,
    T.Nombre AS TESTAMENTOS,
    L.Id_Libro,
    L.Nombre AS LIBRO,
    VE.NumeroCap, 
    VE.NumeroVers, 
    VE.Texto AS VERSICULO,
	B.Id_referencia,
	F.Id_usuario,
	F.FechaFav,
	F.Id_favorito,
	F.NombreFav
FROM 
    DB_Bible.dbo.Idiomas I
LEFT OUTER JOIN 
    DB_Bible.dbo.Versiones V ON I.Id_Idioma = V.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Testamentos T ON I.Id_Idioma = T.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Libros L ON I.Id_Idioma = L.Id_Idioma AND T.Id_Testamento = L.Id_Testamento
LEFT JOIN 
    DB_Bible.dbo.Versiculos VE ON V.Id_Version = VE.Id_Version AND L.Id_Libro = VE.Id_Libro

LEFT JOIN 
	Biblia.ReferenciaBiblia	B ON  B.Id_Idioma = I.Id_Idioma	AND
									B.Id_Version = V.Id_Version AND
									B.Id_Testamento = T.Id_Testamento AND
									B.Id_Libro = L.Id_Libro AND
									B.Id_Versiculo = VE.Id_Vers

LEFT JOIN 
	Consultas.Favorito	F	ON	F.Id_referencia = B.Id_referencia;
	
GO

ALTER VIEW Biblia.V_FavoritosBibliaCapitulos
AS
		SELECT 
    I.Id_Idioma,
    I.Nombre AS IDIOMA,
    V.Id_Version,
    V.NombreVersion AS VERSIONES,
    T.Id_Testamento,
    T.Nombre AS TESTAMENTOS,
    L.Id_Libro,
    L.Nombre AS LIBRO,
    VE.NumeroCap AS CAPITULO,
	VE.NumeroVers AS VERSICULO,
	B.Id_referencia,
	F.Id_usuario,
	F.FechaFav,
	F.Id_favorito,
	F.NombreFav
FROM 
    DB_Bible.dbo.Idiomas I
INNER JOIN 
    DB_Bible.dbo.Versiones V ON I.Id_Idioma = V.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Testamentos T ON I.Id_Idioma = T.Id_Idioma
INNER JOIN 
    DB_Bible.dbo.Libros L ON I.Id_Idioma = L.Id_Idioma AND T.Id_Testamento = L.Id_Testamento
INNER JOIN 
    DB_Bible.dbo.Versiculos VE ON V.Id_Version = VE.Id_Version AND L.Id_Libro = VE.Id_Libro

INNER JOIN 
	Biblia.ReferenciaBiblia	B ON  B.Id_Idioma = I.Id_Idioma	AND
									B.Id_Version = V.Id_Version AND
									B.Id_Testamento = T.Id_Testamento AND
									B.Id_Libro = L.Id_Libro AND
									B.Id_Capitulo = VE.NumeroCap AND
									B.Id_Versiculo = 0

INNER JOIN 
	Consultas.Favorito	F	ON	F.Id_referencia = B.Id_referencia;
	
GO

SELECT * FROM Biblia.V_FavoritosBibliaCapitulos
