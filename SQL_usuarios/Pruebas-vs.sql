
--Ailin E. Granados Cantu
--Pruebas para la verificaicon de datos en vs
--04-11-23

select * from Usuario.UsuarioRegistros

SELECT * FROM Usuario.Genero

INSERT INTO Usuario.Genero (Descripcion) VALUES
('Femenino'),
('Masculino'),
('Sin Especificar')
GO

INSERT INTO Usuario.UsuarioRegistros(Id_Genero, Correo, Fecha_nac, Nombre, ApellidoP, Clave) VALUES
('1', '@gmail', '2002-08-28', 'Ailin', 'Granados', 'jesus123')

