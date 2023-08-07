--Consultas generales
SELECT * FROM Colaborador;

--Creación de tabla colaborador
CREATE TABLE Colaborador(
	ColaboradorId INT IDENTITY (1,1) NOT NULL,
	Nombres VARCHAR(150) NOT NULL,
	Apellidos VARCHAR(150)NOT NULL,
	Genero VARCHAR(15),
	EstadoCivil VARCHAR(15),
	FechaNacimiento DATETIME,
	Edad INT,
	DPI BIGINT,
	IGSS BIGINT,
	IRTRA BIGINT,
	Pasaporte VARCHAR(150),
	Departamento VARCHAR(150),
	Municipio VARCHAR(150),
	DireccionResidencia VARCHAR(150)
	)

--Creación de procedimientos almacenados para CRUD.
--Obtener colaborador
CREATE PROCEDURE SP_ObtenerColaborador
AS
SELECT * FROM Colaborador
ORDER BY ColaboradorId DESC

--Agregar colaborador
CREATE PROCEDURE SP_AgregarColaborador
@nombres VARCHAR(150),
@apellidos VARCHAR(150),
@genero VARCHAR(15),
@estadoCivil VARCHAR(15),
@fechaNacimiento DATETIME,
@edad INT,
@dpi BIGINT,
@igss BIGINT,
@irtra BIGINT,
@pasaporte VARCHAR(150),
@departamento VARCHAR(150),
@municipio VARCHAR(150),
@direccionResidencia VARCHAR(150)
AS
INSERT INTO Colaborador(Nombres, Apellidos, Genero, EstadoCivil, FechaNacimiento, Edad, DPI, IGSS, IRTRA, Pasaporte, Departamento, Municipio, DireccionResidencia)
VALUES (@nombres, @apellidos, @genero, @estadoCivil, @fechaNacimiento, @edad, @dpi, @igss, @irtra, @pasaporte, @departamento, @municipio, @direccionResidencia)

--Actualizar colaborador
CREATE PROCEDURE SP_ActualizaColaborador
@colaboradorId INT,
@nombres VARCHAR(150),
@apellidos VARCHAR(150),
@genero VARCHAR(15),
@estadoCivil VARCHAR(15),
@fechaNacimiento DATETIME,
@edad INT,
@dpi BIGINT,
@igss BIGINT,
@irtra BIGINT,
@pasaporte VARCHAR(150),
@departamento VARCHAR(150),
@municipio VARCHAR(150),
@direccionResidencia VARCHAR(150)
AS
UPDATE Colaborador
SET
Nombres = @nombres,
Apellidos = @apellidos,
Genero = @genero,
EstadoCivil = @estadoCivil,
FechaNacimiento = @fechaNacimiento,
Edad = @edad,
DPI = @dpi,
IGSS = @igss,
IRTRA = @irtra,
Pasaporte = @pasaporte,
Departamento = @departamento,
Municipio = @municipio,
DireccionResidencia = @direccionResidencia
WHERE ColaboradorId = @colaboradorId

--Eliminar colaborador.
CREATE PROCEDURE SP_BorrarColaborador
@colaboradorId INT
AS
DELETE FROM Colaborador
WHERE ColaboradorId = @colaboradorId