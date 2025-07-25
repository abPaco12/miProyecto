USE [dbBanco]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 04/07/2025 19:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[telefono] [nvarchar](8) NULL,
	[correo] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Listadocliente]    Script Date: 04/07/2025 19:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Listadocliente]
AS
BEGIN
    SELECT * FROM usuarios; -- o la tabla que necesites
END
GO
/****** Object:  StoredProcedure [dbo].[spActualizarUsuario]    Script Date: 04/07/2025 19:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spActualizarUsuario]
    @id INT,
    @nombre VARCHAR(20),
    @apellido VARCHAR(20),
    @telefono NVARCHAR(8),
    @correo NVARCHAR(100),
    @mensaje VARCHAR(50) OUTPUT -- Mensaje de salida
AS
BEGIN
    -- Verificar si el usuario existe
    IF NOT EXISTS (SELECT 1 FROM usuarios WHERE id = @id)
    BEGIN
        SET @mensaje = 'EL USUARIO NO EXISTE';
    END
    ELSE
    BEGIN
        -- Actualizar datos
        UPDATE usuarios
        SET
            nombre = @nombre,
            apellido = @apellido,
            telefono = @telefono,
            correo = @correo
        WHERE
            id = @id;

        SET @mensaje = 'USUARIO ACTUALIZADO CORRECTAMENTE';
    END
END;

GO
/****** Object:  StoredProcedure [dbo].[spBuscarUsuario]    Script Date: 04/07/2025 19:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spBuscarUsuario]
    @id int
AS
BEGIN
    SELECT *
    FROM usuarios
    WHERE id=@id;
END;
GO
/****** Object:  StoredProcedure [dbo].[spEliminarCliente]    Script Date: 04/07/2025 19:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarCliente]
    @Id INT, -- ID del cliente a eliminar
    @mensaje VARCHAR(50) OUTPUT -- Mensaje de salida
AS
BEGIN
    BEGIN TRY
        -- Verificar si existe el cliente
        IF EXISTS (SELECT 1 FROM usuarios WHERE Id = @Id)
        BEGIN
            -- Eliminar
            DELETE FROM usuarios WHERE Id = @Id;

            SET @mensaje = 'CLIENTE ELIMINADO CORRECTAMENTE';
        END
        ELSE
        BEGIN
            SET @mensaje = 'CLIENTE NO EXISTE';
        END
    END TRY
    BEGIN CATCH
        SET @mensaje = 'ERROR AL ELIMINAR CLIENTE';
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[spRegistrarUsuario]    Script Date: 04/07/2025 19:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRegistrarUsuario]
    @nombre VARCHAR(20),
    @apellido VARCHAR(20),
    @telefono NVARCHAR(8),
    @correo NVARCHAR(100),
    @Id INT OUTPUT,             -- Este devolverá el ID generado
    @mensaje VARCHAR(50) OUTPUT -- Mensaje de salida
AS
BEGIN
    BEGIN TRY
        -- Obtener el siguiente ID manualmente
        SELECT @Id = ISNULL(MAX(id),0) + 1 FROM usuarios;

        -- Insertar nuevo usuario
        INSERT INTO usuarios (id, nombre, apellido, telefono, correo)
        VALUES (@Id, @nombre, @apellido, @telefono, @correo);

        SET @mensaje = 'USUARIO REGISTRADO CORRECTAMENTE';
    END TRY
    BEGIN CATCH
        -- En caso de error
        SET @mensaje = 'ERROR AL REGISTRAR USUARIO';
        -- Puedes también retornar -1 como id para señalar error
        SET @Id = -1;
    END CATCH
END;
GO
