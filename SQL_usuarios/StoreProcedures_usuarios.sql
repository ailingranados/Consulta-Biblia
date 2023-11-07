--Ailin E. Granados Cantu
--07/11/23
--Store Procedures para esquema Usuarios

USE DB_Usuarios

SELECT * FROM Usuario.UsuarioRegistros

SELECT * FROM Relaciones.UsuarioEstatus

SELECT * FROM Usuario.Contraseña

SELECT * FROM Consultas.Historial
GO
--***********************************************Usuarios

--LOS DOS PROCEDURES VAN JUNTOS, 
--el primero inserta datos
CREATE PROCEDURE SP_InsertarNuevoUsuario
@Id_Genero		TINYINT, 
@Correo			VARCHAR (20), 
@Fecha_nac		DATETIME, 
@Nombre			VARCHAR(10), 
@ApellidoM		VARCHAR(10), 
@ApellidoP		VARCHAR(10), 
@Clave			VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Usuario.UsuarioRegistros(
		Id_Genero, Correo, Fecha_nac, Nombre, 
		ApellidoM, ApellidoP, Clave)

	VALUES(
		@Id_Genero, @Correo, @Fecha_nac, @Nombre, 
		@ApellidoM, @ApellidoP, @Clave);

END
GO

--el segundo activa el usuario
CREATE PROCEDURE SP_ActivarUsuario
AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Relaciones.UsuarioEstatus(
	FechaReg, Id_estatus, Id_usuario)

	VALUES
	(GETDATE(), '1', (select max(Id_usuario) as id from Usuario.UsuarioRegistros))

END
GO

--EXEC SP_ActivarUsuario


CREATE PROCEDURE SP_ActualizarUsuario
@Id_usuario		INT,
@Correo			VARCHAR (20), 
@Nombre			VARCHAR(10), 
@ApellidoM		VARCHAR(10), 
@ApellidoP		VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;
	UPDATE Usuario.UsuarioRegistros
	SET
		Correo		=	@Correo,
		Nombre		=	@Nombre,
		ApellidoM	=	@ApellidoM,
		ApellidoP	=	@ApellidoP
		WHERE
		Id_usuario	= @Id_usuario;

END
GO

CREATE PROCEDURE SP_EliminarUsuario
@Id_UsEst		SMALLINT

AS
BEGIN
SET NOCOUNT ON;
	UPDATE Relaciones.UsuarioEstatus
	SET
		Id_estatus	=	2,
		FechaBaja	=	GETDATE()
	WHERE
		Id_UsEst = @Id_UsEst;
END
GO

--EXEC SP_EliminarUsuario @Id_UsEst = 1

CREATE PROCEDURE SP_CambioContraseña
@Id_usuario SMALLINT,
@ConNueva	VARCHAR(10),
@ConVieja	VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;

	UPDATE	Usuario.Contraseña
	SET
		ConVieja1	=	@ConVieja,
		ConNueva	=	@ConNueva

	WHERE	
	Id_usuario	=	@Id_usuario;

END
GO

CREATE PROCEDURE SP_SegundoCambioContraseña
@Id_usuario SMALLINT,
@ConNueva	VARCHAR(10),
@ConVieja	VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;

	UPDATE	Usuario.Contraseña
	SET
		ConVieja2	=	@ConVieja,
		ConNueva	=	@ConNueva

	WHERE	
	Id_usuario	=	@Id_usuario;

END
GO

CREATE PROCEDURE SP_InsertarHistorial
@Texto			VARCHAR(20),
@Id_busqueda		SMALLINT

AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Consultas.Historial(
		Texto, Id_busqueda, FechaBus) 

	VALUES(
		@Texto, @Id_busqueda, GETDATE());
END
GO

