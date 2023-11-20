--Ailin E. Granados Cantu
--12/11/2023
--HISTORIAL


CREATE PROCEDURE Consultas.SP_InsertarConsulta
@Id_referencia	SMALLINT,
@Id_usuario		SMALLINT
AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Consultas.Consulta	(Id_referencia, Id_usuario)
	VALUES (@Id_referencia, @Id_usuario)

END
GO

ALTER TRIGGER Consultas.T_HistorialConsulta
ON Consultas.Consulta
AFTER INSERT
AS
BEGIN
	DECLARE @Id AS INT = (SELECT Id_consulta FROM inserted)

	INSERT INTO Consultas.Historial(Texto, FechaBus, Consulta)
	VALUES ('CONSULTA', GETDATE(), @Id)

END
GO



ALTER PROCEDURE Consultas.SP_BuscarHistorial
@Id_usuario	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT Id_historial, Texto, FechaBus, Id_usuario, Id_referencia,
	Id_Idioma, Id_Version, Id_Testamento, Id_Libro, Id_Capitulo, Id_Versiculo
	FROM Consultas.V_Historial
	WHERE Id_usuario = @Id_usuario
	ORDER BY FechaBus DESC
END
GO



ALTER PROCEDURE Consultas.SP_EliminarHistorial
@Id_historial	SMALLINT
AS
BEGIN
SET NOCOUNT ON;
		DELETE FROM Consultas.Historial
			WHERE Id_historial = @Id_historial
				
END
GO


CREATE PROCEDURE Consultas.SP_BuscarHistorialBusqueda
@Id_usuario		SMALLINT
AS
BEGIN
SET NOCOUNT ON;
	SELECT Id_historial,
	BUSQUEDA,
	FechaBus,
	Id_busqueda,
	Id_usuario,
	Texto
	FROM Consultas.V_HistorialBusqueda
	WHERE Id_usuario = @Id_usuario
	ORDER BY FechaBus DESC
END
GO

