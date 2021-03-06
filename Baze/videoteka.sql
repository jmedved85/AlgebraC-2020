USE [master]
GO
/****** Object:  Database [zadatak_1_3]    Script Date: 26.1.2021. 19:49:51 ******/
CREATE DATABASE [zadatak_1_3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'zadatak_1_3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\zadatak_1_3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'zadatak_1_3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\zadatak_1_3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [zadatak_1_3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [zadatak_1_3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [zadatak_1_3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [zadatak_1_3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [zadatak_1_3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [zadatak_1_3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [zadatak_1_3] SET ARITHABORT OFF 
GO
ALTER DATABASE [zadatak_1_3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [zadatak_1_3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [zadatak_1_3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [zadatak_1_3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [zadatak_1_3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [zadatak_1_3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [zadatak_1_3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [zadatak_1_3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [zadatak_1_3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [zadatak_1_3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [zadatak_1_3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [zadatak_1_3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [zadatak_1_3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [zadatak_1_3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [zadatak_1_3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [zadatak_1_3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [zadatak_1_3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [zadatak_1_3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [zadatak_1_3] SET  MULTI_USER 
GO
ALTER DATABASE [zadatak_1_3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [zadatak_1_3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [zadatak_1_3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [zadatak_1_3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [zadatak_1_3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [zadatak_1_3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [zadatak_1_3] SET QUERY_STORE = OFF
GO
USE [zadatak_1_3]
GO
/****** Object:  Table [dbo].[cjenik]    Script Date: 26.1.2021. 19:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cjenik](
	[ID_cjenika] [int] IDENTITY(1,1) NOT NULL,
	[kategorija] [nvarchar](50) NOT NULL,
	[cijena] [money] NOT NULL,
 CONSTRAINT [PK_cjenik] PRIMARY KEY CLUSTERED 
(
	[ID_cjenika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clanovi]    Script Date: 26.1.2021. 19:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clanovi](
	[ID_clanski_broj] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nvarchar](50) NOT NULL,
	[prezime] [nvarchar](50) NOT NULL,
	[adresa] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NULL,
	[datum_uclanjenja] [smalldatetime] NULL,
 CONSTRAINT [PK_clanovi] PRIMARY KEY CLUSTERED 
(
	[ID_clanski_broj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[filmovi]    Script Date: 26.1.2021. 19:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filmovi](
	[ID_filma] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
	[reziser] [nvarchar](50) NULL,
	[glavni_glumci] [nvarchar](50) NULL,
	[godina_izdanja] [nvarchar](50) NULL,
	[kolicina_dvd] [int] NULL,
	[kolicina_vhs] [int] NULL,
	[slika_naslovnica] [image] NULL,
	[ID_zanra] [int] NOT NULL,
 CONSTRAINT [PK_filmovi] PRIMARY KEY CLUSTERED 
(
	[ID_filma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[posudba]    Script Date: 26.1.2021. 19:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posudba](
	[ID_clanski_broj] [int] NOT NULL,
	[ID_filma] [int] NOT NULL,
	[datum_posudbe] [smalldatetime] NOT NULL,
	[datum_povrata] [smalldatetime] NULL,
	[ID_cjenika] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zanr]    Script Date: 26.1.2021. 19:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zanr](
	[ID_zanra] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_zanr] PRIMARY KEY CLUSTERED 
(
	[ID_zanra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cjenik] ON 

INSERT [dbo].[cjenik] ([ID_cjenika], [kategorija], [cijena]) VALUES (1, N'Hit DVD', 15.0000)
INSERT [dbo].[cjenik] ([ID_cjenika], [kategorija], [cijena]) VALUES (2, N'DVD', 12.0000)
INSERT [dbo].[cjenik] ([ID_cjenika], [kategorija], [cijena]) VALUES (3, N'Hit VHS', 12.0000)
INSERT [dbo].[cjenik] ([ID_cjenika], [kategorija], [cijena]) VALUES (4, N'VHS', 10.0000)
INSERT [dbo].[cjenik] ([ID_cjenika], [kategorija], [cijena]) VALUES (5, N'Stari VHS', 8.0000)
SET IDENTITY_INSERT [dbo].[cjenik] OFF
GO
SET IDENTITY_INSERT [dbo].[clanovi] ON 

INSERT [dbo].[clanovi] ([ID_clanski_broj], [ime], [prezime], [adresa], [telefon], [datum_uclanjenja]) VALUES (1, N'Jasmin', N'Medved', N'Antuna Vramca 2', N'0953731895', CAST(N'2021-01-25T00:00:00' AS SmallDateTime))
INSERT [dbo].[clanovi] ([ID_clanski_broj], [ime], [prezime], [adresa], [telefon], [datum_uclanjenja]) VALUES (2, N'Slađana', N'Benkus', N'Cerje Nebojse 53', N'0996461653', CAST(N'2021-01-25T00:00:00' AS SmallDateTime))
INSERT [dbo].[clanovi] ([ID_clanski_broj], [ime], [prezime], [adresa], [telefon], [datum_uclanjenja]) VALUES (3, N'Pero', N'Perić', N'Vatroslava Lisinskog3', N'091457233', CAST(N'2021-01-26T00:00:00' AS SmallDateTime))
INSERT [dbo].[clanovi] ([ID_clanski_broj], [ime], [prezime], [adresa], [telefon], [datum_uclanjenja]) VALUES (4, N'Mirko', N'Mirković', N'Ivana Bubeka 3', N'098376444', CAST(N'2021-01-26T00:00:00' AS SmallDateTime))
INSERT [dbo].[clanovi] ([ID_clanski_broj], [ime], [prezime], [adresa], [telefon], [datum_uclanjenja]) VALUES (5, N'Manda', N'Kukić', N'Miroslava Krleže 17', N'0994567222', CAST(N'2021-01-27T00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[clanovi] OFF
GO
SET IDENTITY_INSERT [dbo].[filmovi] ON 

INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (1, N'Policajac iz Beverly Hillsa 1', N'Martin Brest', N'Eddie Murphy', N'1984', 1, 3, NULL, 12)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (2, N'Policajac iz Beverly Hillsa 2', N'Tony Scott', N'Eddie Murphy', N'1987', 1, 3, NULL, 12)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (3, N'Brzina', N'Jan de Bont', N'Keanu Reeves', N'1994', 2, 2, NULL, 1)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (4, N'Casino Royale', N'Martin Campbell', N'Daniel Craig', N'2006', 2, 0, NULL, 1)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (5, N'Potraga za Nemom', N'Andrew Stanton', NULL, N'2003', 3, 0, NULL, 2)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (6, N'Spartak', N'Stanley Kubrick', N'Kirk Douglas', N'1960', 0, 1, NULL, 3)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (7, N'Sam u kući 1', N'Chris Columbus', N'Macaulay Culkin', N'1990', 3, 2, NULL, 4)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (8, N'Sam u kući 2: Izgubljen u New Yorku', N'Chris Columbus', N'Macaulay Culkin', N'1992', 3, 2, NULL, 4)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (9, N'Senna', N'Asif Kapadia', NULL, N'2010', 2, 0, NULL, 5)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (10, N'Rocky 1', N'John G. Avildsen', N'Sylvester Stallone', N'1976', 2, 2, NULL, 6)
INSERT [dbo].[filmovi] ([ID_filma], [naziv], [reziser], [glavni_glumci], [godina_izdanja], [kolicina_dvd], [kolicina_vhs], [slika_naslovnica], [ID_zanra]) VALUES (11, N'Rocky 2', N'Sylvester Stallone', N'Sylvester Stallone', N'1979', 2, 2, NULL, 6)
SET IDENTITY_INSERT [dbo].[filmovi] OFF
GO
INSERT [dbo].[posudba] ([ID_clanski_broj], [ID_filma], [datum_posudbe], [datum_povrata], [ID_cjenika]) VALUES (1, 1, CAST(N'2021-01-25T00:00:00' AS SmallDateTime), NULL, 5)
INSERT [dbo].[posudba] ([ID_clanski_broj], [ID_filma], [datum_posudbe], [datum_povrata], [ID_cjenika]) VALUES (2, 5, CAST(N'2021-01-25T00:00:00' AS SmallDateTime), CAST(N'2021-01-26T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[posudba] ([ID_clanski_broj], [ID_filma], [datum_posudbe], [datum_povrata], [ID_cjenika]) VALUES (3, 6, CAST(N'2021-01-26T00:00:00' AS SmallDateTime), CAST(N'2021-01-27T00:00:00' AS SmallDateTime), 5)
INSERT [dbo].[posudba] ([ID_clanski_broj], [ID_filma], [datum_posudbe], [datum_povrata], [ID_cjenika]) VALUES (4, 9, CAST(N'2021-01-26T00:00:00' AS SmallDateTime), CAST(N'2021-01-27T00:00:00' AS SmallDateTime), 2)
INSERT [dbo].[posudba] ([ID_clanski_broj], [ID_filma], [datum_posudbe], [datum_povrata], [ID_cjenika]) VALUES (5, 7, CAST(N'2021-01-27T00:00:00' AS SmallDateTime), CAST(N'2021-01-28T00:00:00' AS SmallDateTime), 3)
GO
SET IDENTITY_INSERT [dbo].[zanr] ON 

INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (1, N'akcijski')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (2, N'animirani')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (3, N'biografski')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (4, N'božićni')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (5, N'dokumentarni')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (6, N'dramski')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (7, N'erotski')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (8, N'fantastični')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (9, N'film ceste')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (10, N'glazbeni')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (11, N'horor')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (12, N'komedija')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (13, N'krimi')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (14, N'kršćanski')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (15, N'o odrastanju')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (16, N'politički')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (17, N'povijesni')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (18, N'pustolovni')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (19, N'ratni')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (20, N'romantični')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (21, N'satirični')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (22, N'triler')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (23, N'vestern')
INSERT [dbo].[zanr] ([ID_zanra], [naziv]) VALUES (24, N'znanstvenofantastični')
SET IDENTITY_INSERT [dbo].[zanr] OFF
GO
ALTER TABLE [dbo].[filmovi]  WITH CHECK ADD  CONSTRAINT [FK_filmovi_zanr] FOREIGN KEY([ID_zanra])
REFERENCES [dbo].[zanr] ([ID_zanra])
GO
ALTER TABLE [dbo].[filmovi] CHECK CONSTRAINT [FK_filmovi_zanr]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_cjenik] FOREIGN KEY([ID_cjenika])
REFERENCES [dbo].[cjenik] ([ID_cjenika])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_cjenik]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_clanovi] FOREIGN KEY([ID_clanski_broj])
REFERENCES [dbo].[clanovi] ([ID_clanski_broj])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_clanovi]
GO
ALTER TABLE [dbo].[posudba]  WITH CHECK ADD  CONSTRAINT [FK_posudba_filmovi] FOREIGN KEY([ID_filma])
REFERENCES [dbo].[filmovi] ([ID_filma])
GO
ALTER TABLE [dbo].[posudba] CHECK CONSTRAINT [FK_posudba_filmovi]
GO
USE [master]
GO
ALTER DATABASE [zadatak_1_3] SET  READ_WRITE 
GO
