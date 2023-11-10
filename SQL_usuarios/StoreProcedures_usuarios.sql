--Ailin E. Granados Cantu
--07/11/23
--Store Procedures para esquema Usuarios


--DELETE FROM Usuario.UsuarioRegistros WHERE Id_usuario = 5;
--EXEC SP_InsertarNuevoUsuario 1, 'ELI@uanl', '2001-04-25', 'ELI', 'CAN', 'TU', '123'
--EXEC SP_EliminarUsuario @Id_UsEst = 1
--DROP PROCEDURE SP_InsertarNuevoUsuario


USE DB_Usuarios

--SELECT * FROM Usuario.UsuarioRegistros

--SELECT * FROM Relaciones.UsuarioEstatus

--SELECT * FROM Usuario.Contraseña

--SELECT * FROM Consultas.Historial

SELECT * FROM Usuario.UsuarioRegistros
GO
--***********************************************Usuarios

--SPROCEDURES ANIDADOS
--inserta datos
CREATE PROCEDURE SP_InsertarNuevoUsuario
@Id_Genero		TINYINT, 
@Correo			VARCHAR (40), 
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

	EXEC SP_ActivarUsuario @Clave

END
GO


--activa el usuario
CREATE PROCEDURE SP_ActivarUsuario
@clave		VARCHAR(10)

AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Relaciones.UsuarioEstatus
		(FechaReg, 
		Id_estatus, 
		Id_usuario)

		VALUES
		(GETDATE(),
		'1', 
		(select max(Id_usuario) as id from Usuario.UsuarioRegistros))

	INSERT INTO Usuario.Contraseña
	(ConNueva, Id_usuario)

		VALUES
		(@clave, 
		(select max(Id_usuario) as id from Usuario.UsuarioRegistros))

END
GO

CREATE PROCEDURE SP_ActivarContraseña
@clave	VARCHAR(10),

AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO Usuario.Contraseña
	(ConNueva, Id_usuario)

		VALUES
		(@clave, @id_usuario)

END
GO
--EXEC SP_ActivarUsuario


CREATE PROCEDURE SP_ActualizarUsuario
@Id_usuario		INT,
@Nombre			VARCHAR(10), 
@ApellidoM		VARCHAR(10), 
@ApellidoP		VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;
	UPDATE Usuario.UsuarioRegistros
	SET
		
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


CREATE PROCEDURE SP_LeerUsRegistrados
AS
BEGIN
SET NOCOUNT ON
	SELECT 
	Id_usuario, Id_Genero, Correo, Fecha_nac,
	Nombre, ApellidoM, ApellidoP, Clave

		FROM Usuario.UsuarioRegistros
END
GO

CREATE PROCEDURE SP_BuscarUsuario
@Id_usuario	INT
AS
BEGIN
SET NOCOUNT ON
	SELECT 
	Id_usuario,
	Id_Genero, 
	Correo, 
	Fecha_nac,
	Nombre, 
	ApellidoM, 
	ApellidoP, 
	Clave

		FROM 
		Usuario.UsuarioRegistros
			WHERE 
			Id_usuario = @Id_usuario
END
GO

CREATE PROCEDURE SP_LeerEstatusUsu
AS
BEGIN
SET NOCOUNT ON
	SELECT 
		Id_UsEst, FechaReg, FechaBaja, Id_estatus,Id_usuario

		FROM Relaciones.UsuarioEstatus
END
GO

CREATE PROCEDURE SP_IniciarSesion
@correo			VARCHAR(20),
@clave			VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;
	SELECT 
		Id_usuario,
		Id_Genero, 
		Correo, 
		Fecha_nac, 
		Nombre, 
		ApellidoM, 
		ApellidoP, 
		Clave

		FROM 
			Usuario.UsuarioRegistros
	
		WHERE 
			Correo = @correo AND 
			Clave = @clave
END
GO

CREATE PROCEDURE SP_ActualizaConPrincipal
@Id_usuario SMALLINT,
@ConNueva	VARCHAR(10)
AS
BEGIN
SET NOCOUNT ON;

	UPDATE	Usuario.UsuarioRegistros
		SET
			Clave		=	@ConNueva

		WHERE	
			Id_usuario	=	@Id_usuario;

END
GO

--EXEC SP_LeerUsRegistrados
GO

--EXEC SP_LeerEstatusUsu
GO

--EXEC SP_ActivarUsuario
GO

--EXEC SP_IniciarSesion '@gmail','jesus123'
GO

