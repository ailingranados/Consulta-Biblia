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


ALTER TRIGGER Consultas.T_Historial
ON Consultas.Historial
AFTER INSERT
AS 
BEGIN
DECLARE @Id AS VARCHAR(20) = (SELECT Texto FROM inserted)
DECLARE @HISTORIAL AS INT = (SELECT Id_historial FROM inserted)
DECLARE @USUARIO AS INT = (SELECT Usuario FROM inserted)
--DECLARE @REFERENCIA AS INT = (SELECT Id_referencia FROM inserted)

IF(@Id = 'CONSULTA')
	BEGIN
		UPDATE Consultas.Consulta
		SET
			Historial = @HISTORIAL
			WHERE Id_usuario = @USUARIO 
	END
ELSE
	BEGIN
		UPDATE Consultas.Busqueda
		SET
			Historial = @HISTORIAL
			WHERE Id_usuario = @USUARIO
	END
END

GO

CREATE PROCEDURE Consultas.SP_BuscarHistorial
@Id_usuario	SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	SELECT * FROM Consultas.V_Historial
	WHERE Id_usuario = @Id_usuario
	
END
GO

EXEC Consultas.SP_BuscarHistorial 33
