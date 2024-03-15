USE [BD_JOBS]
GO
/****** Object:  Table [dbo].[Tusuario]    Script Date: 15/03/2024 11:46:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tusuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](100) NULL,
	[apellidos] [varchar](100) NULL,
	[edad] [int] NULL,
 CONSTRAINT [PK_Tusuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_usuario_sel]    Script Date: 15/03/2024 11:46:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_usuario_sel]
	AS
BEGIN
	SELECT 
		idUsuario, 
		nombres, 
		apellidos, 
		edad 
	FROM Tusuario
END

GO
/****** Object:  StoredProcedure [dbo].[sp_usuarioById]    Script Date: 15/03/2024 11:46:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_usuarioById]
(
	@idUsuario	INT
)
	AS
BEGIN
	SELECT 
		idUsuario, 
		nombres, 
		apellidos, 
		edad 
	FROM Tusuario
	WHERE idUsuario = @idUsuario
END

GO
