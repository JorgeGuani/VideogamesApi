USE [Videogames]
GO
/****** Object:  Table [dbo].[Videogame]    Script Date: 22/07/2023 01:03:30 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Videogame](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Categoria] [nvarchar](100) NULL,
	[AnioLanzamiento] [int] NULL,
	[Clasificacion] [nvarchar](10) NULL,
	[Plataformas] [nchar](50) NULL,
 CONSTRAINT [PK_Videogame] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Videogame] ON 

INSERT [dbo].[Videogame] ([Id], [Nombre], [Categoria], [AnioLanzamiento], [Clasificacion], [Plataformas]) VALUES (1, N'Mario Bros', N'Aventura', 1985, N'ESRB', N'Nintendo                                          ')
INSERT [dbo].[Videogame] ([Id], [Nombre], [Categoria], [AnioLanzamiento], [Clasificacion], [Plataformas]) VALUES (2, N'Pac-Man', N'Maze', 1980, N'ESRB', N'Arcade                                            ')
INSERT [dbo].[Videogame] ([Id], [Nombre], [Categoria], [AnioLanzamiento], [Clasificacion], [Plataformas]) VALUES (3, N'Crash Bandicoot', N'Aventura', 1996, N'ESRB', N'PlayStation                                       ')
INSERT [dbo].[Videogame] ([Id], [Nombre], [Categoria], [AnioLanzamiento], [Clasificacion], [Plataformas]) VALUES (1002, N'prueba-edit22', N'horror', 2001, N'17+', N'pc, playstation                                   ')
INSERT [dbo].[Videogame] ([Id], [Nombre], [Categoria], [AnioLanzamiento], [Clasificacion], [Plataformas]) VALUES (2004, N'The last of us', N'Aventura, Supervivencia', 2013, N'18+', N'PlayStation 3, PlayStation 4, PC                  ')
SET IDENTITY_INSERT [dbo].[Videogame] OFF
GO
