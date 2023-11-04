
use DB_Usuarios

SELECT 
    T.name AS Tabla,
    C.name as Campo,
    TP.name + '(' + CAST(TP.max_length AS VARCHAR) + ')' AS 'Tipo de Campo',
    (CASE 
        WHEN C.is_nullable = 0 THEN 'NULL'
        WHEN C.is_nullable = 1 THEN 'NOT NULL'
    END) AS 'Valor por defecto',
    (CASE 
        WHEN C.is_nullable = 0 THEN 'NO'
        WHEN C.is_nullable = 1 THEN 'SÍ'
    END) AS 'Requerido'
	,ep.value [Descripcion]
FROM SYS.TABLES T
    INNER JOIN SYS.COLUMNS C
        ON T.OBJECT_ID = C.OBJECT_ID
    INNER JOIN sys.types TP
        ON C.user_type_id = TP.user_type_id
	inner join sys.objects d 
		On T.object_id= d.object_id 
	left JOIN sys.extended_properties ep 
		ON d.object_id = ep.major_id AND c.column_id = ep.minor_id
ORDER BY T.name, c.column_id

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Clave primaria para identificar la busqueda',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Busqueda',
@level2type = N'Column', @level2name = 'Id_busqueda';
GO

EXEC sp_addextendedproperty
@name = N'MS_texto', @value = 'Texto que se pide buscar en BIBLIA',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Busqueda',
@level2type = N'Column', @level2name = 'Texto';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha en la que se realizo la consulta',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Busqueda',
@level2type = N'Column', @level2name = 'Fecha';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'id del usuario que relaiza la consulta',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Busqueda',
@level2type = N'Column', @level2name = 'Id_usuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de consulta',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Consulta',
@level2type = N'Column', @level2name = 'Id_consulta';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'El texto que el usuario esta buscando',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Consulta',
@level2type = N'Column', @level2name = 'Consulta';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de contraseña',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Contraseña',
@level2type = N'Column', @level2name = 'Id_contraseña';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'La contraseña actual del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Contraseña',
@level2type = N'Column', @level2name = 'ConPrincipal';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Contraseña antigua del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Contraseña',
@level2type = N'Column', @level2name = 'ConVieja1';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Segunda contraseña antigua del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Contraseña',
@level2type = N'Column', @level2name = 'ConVieja2';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id del usuario al que le pertenecen las contraseñas',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Contraseña',
@level2type = N'Column', @level2name = 'Id_usuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de estatus',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Estatus',
@level2type = N'Column', @level2name = 'Id_estatus';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'El tipo de estatus al que pertenece cada id',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Estatus',
@level2type = N'Column', @level2name = 'Descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de favoritos',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Favorito',
@level2type = N'Column', @level2name = 'Id_favorito';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'id del usuario que guardo el favorito',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Favorito',
@level2type = N'Column', @level2name = 'Id_usuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha en la que se guardo el favorito',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Favorito',
@level2type = N'Column', @level2name = 'FechaFav';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de la relacion',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'FavoritoConsulta',
@level2type = N'Column', @level2name = 'Id_favCon';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'id del favorito que se quiere consultar',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'FavoritoConsulta',
@level2type = N'Column', @level2name = 'Id_favorito';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'id de la consulta que se relaciona con favorito',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'FavoritoConsulta',
@level2type = N'Column', @level2name = 'Id_consulta';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de genero',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Genero',
@level2type = N'Column', @level2name = 'id_genero';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'El nombre que le corresponde a cada id',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'Genero',
@level2type = N'Column', @level2name = 'Descripcion';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de historial',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Historial',
@level2type = N'Column', @level2name = 'id_historial';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'El texto del cual se realizo la busqueda',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Historial',
@level2type = N'Column', @level2name = 'texto';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de la busqeuda que se realizo',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Historial',
@level2type = N'Column', @level2name = 'id_busqueda';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de cuando se realizo la busqueda, atributo de la relacion',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Historial',
@level2type = N'Column', @level2name = 'FechaBus';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de la relacion historial con consulta',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'HistorialConsulta',
@level2type = N'Column', @level2name = 'id_hisCon';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id del historial a consultar',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'HistorialConsulta',
@level2type = N'Column', @level2name = 'id_historial';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de la consulta al historial',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'HistorialConsulta',
@level2type = N'Column', @level2name = 'id_consulta';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'id_usuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id del genero que selecciono el usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'id_genero';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Correo con el que se ingresara al sistema',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'Correo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de nacimiento del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'Fecha_nac';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Primer nombre del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'Nombre';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido materno del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'ApellidoM';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Apellido paterno del usuario',
@level0type = N'Schema', @level0name = 'Usuario',
@level1type = N'Table', @level1name = 'UsuarioRegistros',
@level2type = N'Column', @level2name = 'ApellidoP';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'llave primaria de la relacion del usuario con el estatus',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'UsuarioEstatus',
@level2type = N'Column', @level2name = 'Id_UsEst';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de registro del usuario',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'UsuarioEstatus',
@level2type = N'Column', @level2name = 'FechaReg';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Fecha de baja del usuario',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'UsuarioEstatus',
@level2type = N'Column', @level2name = 'FechaBaja';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id del estatus del usuario',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'UsuarioEstatus',
@level2type = N'Column', @level2name = 'Id_estatus';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id del usuario al que se registra el estatus',
@level0type = N'Schema', @level0name = 'Relaciones',
@level1type = N'Table', @level1name = 'UsuarioEstatus',
@level2type = N'Column', @level2name = 'Id_usuario';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de referencia para identificar en la biblia',
@level0type = N'Schema', @level0name = 'Biblia',
@level1type = N'Table', @level1name = 'ReferenciaBiblia',
@level2type = N'Column', @level2name = 'Id_referencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de idioma para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Biblia',
@level1type = N'Table', @level1name = 'ReferenciaBiblia',
@level2type = N'Column', @level2name = 'Id_Idioma';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de version para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Biblia',
@level1type = N'Table', @level1name = 'ReferenciaBiblia',
@level2type = N'Column', @level2name = 'Id_Version';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de testamento para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Biblia',
@level1type = N'Table', @level1name = 'ReferenciaBiblia',
@level2type = N'Column', @level2name = 'Id_Testamento';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de libro para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Biblia',
@level1type = N'Table', @level1name = 'ReferenciaBiblia',
@level2type = N'Column', @level2name = 'Id_Libro';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de versiculo para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Biblia',
@level1type = N'Table', @level1name = 'ReferenciaBiblia',
@level2type = N'Column', @level2name = 'Id_Versiculo';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de referencia para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Busqueda',
@level2type = N'Column', @level2name = 'Id_referencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de referencia para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Consulta',
@level2type = N'Column', @level2name = 'Id_referencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de referencia para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Favorito',
@level2type = N'Column', @level2name = 'Id_referencia';
GO

EXEC sp_addextendedproperty
@name = N'MS_Description', @value = 'Id de referencia para buscar en la biblia',
@level0type = N'Schema', @level0name = 'Consultas',
@level1type = N'Table', @level1name = 'Historial',
@level2type = N'Column', @level2name = 'Id_referencia';
GO