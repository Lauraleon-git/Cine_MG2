USE [Cine]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cartelera]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cartelera](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Precio] [int] NOT NULL,
	[Cantidad_boletos] [int] NOT NULL,
	[Horario] [datetime2](7) NOT NULL,
	[PromocionID] [int] NOT NULL,
	[PeliculaId] [int] NOT NULL,
	[SalaId] [int] NOT NULL,
	[Estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cartelera] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](50) NOT NULL,
	[Sinopsis] [nvarchar](200) NOT NULL,
	[Director] [nvarchar](50) NOT NULL,
	[Pais] [nvarchar](25) NOT NULL,
	[Año] [int] NOT NULL,
	[Duracion] [nvarchar](max) NOT NULL,
	[Genero] [nvarchar](25) NOT NULL,
	[Productora] [nvarchar](50) NOT NULL,
	[Idioma] [nvarchar](50) NOT NULL,
	[Clasificacion] [nvarchar](50) NOT NULL,
	[PortadaPelicula] [nvarchar](max) NULL,
	[Trailer] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pelicula] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[CI] [int] NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promocion]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promocion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_Promocion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Fecha_reserva] [datetime2](7) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[PersonaId] [int] NOT NULL,
	[CarteleraId] [int] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](10) NOT NULL,
	[Cantidad_Asientos] [int] NOT NULL,
	[Estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/12/2023 12:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[PersonasId] [int] NOT NULL,
	[RolesId] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cartelera]  WITH CHECK ADD  CONSTRAINT [FK_Cartelera_Pelicula_PeliculaId] FOREIGN KEY([PeliculaId])
REFERENCES [dbo].[Pelicula] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cartelera] CHECK CONSTRAINT [FK_Cartelera_Pelicula_PeliculaId]
GO
ALTER TABLE [dbo].[Cartelera]  WITH CHECK ADD  CONSTRAINT [FK_Cartelera_Promocion_PromocionID] FOREIGN KEY([PromocionID])
REFERENCES [dbo].[Promocion] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cartelera] CHECK CONSTRAINT [FK_Cartelera_Promocion_PromocionID]
GO
ALTER TABLE [dbo].[Cartelera]  WITH CHECK ADD  CONSTRAINT [FK_Cartelera_Sala_SalaId] FOREIGN KEY([SalaId])
REFERENCES [dbo].[Sala] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cartelera] CHECK CONSTRAINT [FK_Cartelera_Sala_SalaId]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cartelera_CarteleraId] FOREIGN KEY([CarteleraId])
REFERENCES [dbo].[Cartelera] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cartelera_CarteleraId]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Persona_PersonaId] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Persona] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Persona_PersonaId]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Persona_PersonasId] FOREIGN KEY([PersonasId])
REFERENCES [dbo].[Persona] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Persona_PersonasId]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_RolesId] FOREIGN KEY([RolesId])
REFERENCES [dbo].[Rol] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol_RolesId]
GO
