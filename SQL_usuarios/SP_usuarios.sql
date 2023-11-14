--Ailin E. Granados Cantu
--07/11/23
--Store Procedures para esquema Usuarios

USE DB_Usuarios

--DELETE FROM Usuario.UsuarioRegistros WHERE Id_usuario = 5;
--EXEC SP_InsertarNuevoUsuario 1, 'ailin@uanl', '2001-04-25', 'ai', 'li', 'n', '5'
--EXEC SP_CambioContraseña 12, '456', '123'
--DROP PROCEDURE SP_InsertarNuevoUsuario
--DROP PROCEDURE SP_SegundoCambioContraseña
--DROP PROCEDURE Biblia.SP_GuardarRef
--SELECT * FROM Usuario.UsuarioRegistros


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

DECLARE @ID SMALLINT
SET @ID = (select max(Id_usuario) as id from Usuario.UsuarioRegistros)

	EXEC SP_ActivarUsuario @Clave, @ID
END
GO


--activa el usuario
CREATE PROCEDURE SP_ActivarUsuario
@clave		VARCHAR(10),
@ID			SMALLINT

AS
BEGIN
SET NOCOUNT ON;


	INSERT INTO Usuario.Contraseña
	(ConNueva, Id_usuario)

		VALUES
		(@clave, @ID)

	INSERT INTO Relaciones.UsuarioEstatus
		(FechaReg, 
		Id_estatus, 
		Id_usuario)

		VALUES
		(GETDATE(),'1', @ID)

	UPDATE Usuario.UsuarioRegistros
		SET
			Contraseñas = (select max(Id_contraseña) as id from Usuario.Contraseña)
		WHERE
			Id_usuario = @ID
			
END
GO

CREATE FUNCTION Usuario.UltimoId ()
RETURNS INT 
BEGIN
		DECLARE @Id INT
		SET @Id = (select max(Id_usuario) as id from Usuario.UsuarioRegistros)
		RETURN @Id

END
GO


CREATE PROCEDURE SP_ActivarContraseña
@clave			VARCHAR(10),
@id_usuario		INT
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

	UPDATE	Usuario.UsuarioRegistros
		SET
		Clave	=	@ConNueva
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

	UPDATE	Usuario.UsuarioRegistros
		SET
		Clave	=	@ConNueva
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

CREATE PROCEDURE SP_LeerContraseñaUsu
@Id_usuario	SMALLINT
AS
BEGIN
SET NOCOUNT ON
	SELECT 
	ConVieja1, ConVieja2, ConNueva
		FROM 
		Usuario.Contraseña
			WHERE
			Id_usuario = @Id_usuario
				
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

CREATE PROCEDURE SP_ContraseñasNuevas
@ClaveVieja	VARCHAR(10),
@ClaveNueva	VARCHAR(10),
@Id_usu		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

DECLARE @CON1	VARCHAR(10)
DECLARE @CON2	VARCHAR(10)

SET @CON1 = (SELECT Usuario.BuscarContraseña1(@Id_usu))
SET @CON2 = (SELECT Usuario.BuscarContraseña2(@Id_usu))

--IF((@CON1 != @ClaveNueva) AND (@CON2 != @ClaveNueva) AND (@ClaveVieja != @ClaveNueva))


		IF(@CON1 IS NULL)
			BEGIN
				EXEC SP_CambioContraseña @Id_usu, @ClaveNueva, @ClaveVieja
			END

		ELSE IF (@CON2 IS NULL)
			BEGIN
				EXEC SP_SegundoCambioContraseña @Id_usu, @ClaveNueva, @ClaveVieja
			END

		IF((@CON2 IS NOT NULL) AND (@CON1 IS NOT NULL))
			BEGIN
				EXEC SP_CambioContraseña @Id_usu, @ClaveNueva, @ClaveVieja
			END

		UPDATE Usuario.UsuarioRegistros
			SET
				Clave		=	@ClaveNueva
			WHERE
				Id_usuario	= @Id_usu;


	
END
GO

CREATE FUNCTION Usuario.BuscarContraseña1(@Id_usu INT)
RETURNS VARCHAR(10)
BEGIN

	DECLARE @CON1	VARCHAR(10)
	SET @CON1 = (SELECT ConVieja1 FROM Usuario.Contraseña WHERE Id_usuario = @Id_usu)
	RETURN @CON1

END
GO

CREATE FUNCTION Usuario.BuscarContraseña2(@Id_usu INT)
RETURNS VARCHAR(10)
BEGIN

	DECLARE @CON1	VARCHAR(10)
	SET @CON1 = (SELECT ConVieja2 FROM Usuario.Contraseña WHERE Id_usuario = @Id_usu)
	RETURN @CON1

END
GO

CREATE PROCEDURE Usuario.SP_BajaUsuario
@Id_usuario		SMALLINT
AS
BEGIN
SET NOCOUNT ON;

	UPDATE Relaciones.UsuarioEstatus
		SET
		
		Id_estatus	=	2,
		FechaBaja	=	GETDATE()

			WHERE
			Id_usuario	= @Id_usuario;
END
GO


EXEC Usuario.SP_BajaUsuario 11

