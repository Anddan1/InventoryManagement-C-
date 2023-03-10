USE [master]
GO
/****** Object:  Database [Disertatie]    Script Date: 18/06/2022 12:10:43 AM ******/
CREATE DATABASE [Disertatie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Disertatie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Disertatie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Disertatie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Disertatie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Disertatie] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Disertatie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Disertatie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Disertatie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Disertatie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Disertatie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Disertatie] SET ARITHABORT OFF 
GO
ALTER DATABASE [Disertatie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Disertatie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Disertatie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Disertatie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Disertatie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Disertatie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Disertatie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Disertatie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Disertatie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Disertatie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Disertatie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Disertatie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Disertatie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Disertatie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Disertatie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Disertatie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Disertatie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Disertatie] SET RECOVERY FULL 
GO
ALTER DATABASE [Disertatie] SET  MULTI_USER 
GO
ALTER DATABASE [Disertatie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Disertatie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Disertatie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Disertatie] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Disertatie] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Disertatie] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Disertatie', N'ON'
GO
ALTER DATABASE [Disertatie] SET QUERY_STORE = OFF
GO
USE [Disertatie]
GO
/****** Object:  Table [dbo].[BonTransfer]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BonTransfer](
	[Numar] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NULL,
	[IdMagazie] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denumire] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Adresa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Numar] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NULL,
	[Serie] [nvarchar](50) NULL,
	[IdClient] [int] NULL,
	[IdFurnizor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furnizor]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furnizor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denumire] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Adresa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Magazie]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Magazie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denumire] [nvarchar](50) NULL,
	[Adresa] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaDeReceptieSiConstatare]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaDeReceptieSiConstatare](
	[Numar] [int] IDENTITY(1,1) NOT NULL,
	[Data] [date] NULL,
	[IdMagazie] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produs]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Denumire] [nvarchar](50) NULL,
	[UnitateDeMasura] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProdusFactura]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdusFactura](
	[Numar] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[Pret] [money] NULL,
	[Cantitate] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numar] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProdusTransfer]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdusTransfer](
	[Numar] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[Cantitate] [int] NULL,
	[Pret] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numar] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceptieProdus]    Script Date: 18/06/2022 12:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceptieProdus](
	[Numar] [int] NOT NULL,
	[Id] [int] NOT NULL,
	[CantitateReceptie] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Numar] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BonTransfer]  WITH CHECK ADD  CONSTRAINT [FK_BonTransfer_Magazie] FOREIGN KEY([IdMagazie])
REFERENCES [dbo].[Magazie] ([Id])
GO
ALTER TABLE [dbo].[BonTransfer] CHECK CONSTRAINT [FK_BonTransfer_Magazie]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([IdFurnizor])
REFERENCES [dbo].[Furnizor] ([Id])
GO
ALTER TABLE [dbo].[NotaDeReceptieSiConstatare]  WITH CHECK ADD  CONSTRAINT [FK_NotaDeReceptieSiConstatare_Magazie] FOREIGN KEY([IdMagazie])
REFERENCES [dbo].[Magazie] ([Id])
GO
ALTER TABLE [dbo].[NotaDeReceptieSiConstatare] CHECK CONSTRAINT [FK_NotaDeReceptieSiConstatare_Magazie]
GO
ALTER TABLE [dbo].[ProdusFactura]  WITH CHECK ADD  CONSTRAINT [FK_ProdusFactura_Factura] FOREIGN KEY([Numar])
REFERENCES [dbo].[Factura] ([Numar])
GO
ALTER TABLE [dbo].[ProdusFactura] CHECK CONSTRAINT [FK_ProdusFactura_Factura]
GO
ALTER TABLE [dbo].[ProdusFactura]  WITH CHECK ADD  CONSTRAINT [FK_ProdusFactura_Produs] FOREIGN KEY([Id])
REFERENCES [dbo].[Produs] ([Id])
GO
ALTER TABLE [dbo].[ProdusFactura] CHECK CONSTRAINT [FK_ProdusFactura_Produs]
GO
ALTER TABLE [dbo].[ProdusTransfer]  WITH CHECK ADD  CONSTRAINT [FK_ProdusTransfer_BonTransfer] FOREIGN KEY([Numar])
REFERENCES [dbo].[BonTransfer] ([Numar])
GO
ALTER TABLE [dbo].[ProdusTransfer] CHECK CONSTRAINT [FK_ProdusTransfer_BonTransfer]
GO
ALTER TABLE [dbo].[ProdusTransfer]  WITH CHECK ADD  CONSTRAINT [FK_ProdusTransfer_Produs] FOREIGN KEY([Id])
REFERENCES [dbo].[Produs] ([Id])
GO
ALTER TABLE [dbo].[ProdusTransfer] CHECK CONSTRAINT [FK_ProdusTransfer_Produs]
GO
ALTER TABLE [dbo].[ReceptieProdus]  WITH CHECK ADD  CONSTRAINT [FK_ReceptieProdus_NotaDeReceptieSiConstatare] FOREIGN KEY([Numar])
REFERENCES [dbo].[NotaDeReceptieSiConstatare] ([Numar])
GO
ALTER TABLE [dbo].[ReceptieProdus] CHECK CONSTRAINT [FK_ReceptieProdus_NotaDeReceptieSiConstatare]
GO
ALTER TABLE [dbo].[ReceptieProdus]  WITH CHECK ADD  CONSTRAINT [FK_ReceptieProdus_Produs] FOREIGN KEY([Id])
REFERENCES [dbo].[Produs] ([Id])
GO
ALTER TABLE [dbo].[ReceptieProdus] CHECK CONSTRAINT [FK_ReceptieProdus_Produs]
GO
USE [master]
GO
ALTER DATABASE [Disertatie] SET  READ_WRITE 
GO
