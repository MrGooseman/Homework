USE [master]
GO
/****** Object:  Database [Homework_DB]    Script Date: 08.05.2021 17:35:05 ******/
CREATE DATABASE [Homework_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Homework_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Homework_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Homework_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Homework_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Homework_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Homework_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Homework_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Homework_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Homework_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Homework_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Homework_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Homework_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Homework_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Homework_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Homework_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Homework_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Homework_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Homework_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Homework_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Homework_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Homework_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Homework_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Homework_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Homework_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Homework_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Homework_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Homework_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Homework_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Homework_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [Homework_DB] SET  MULTI_USER 
GO
ALTER DATABASE [Homework_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Homework_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Homework_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Homework_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Homework_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Homework_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Homework_DB', N'ON'
GO
ALTER DATABASE [Homework_DB] SET QUERY_STORE = OFF
GO
USE [Homework_DB]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 08.05.2021 17:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SurName] [nvarchar](30) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[User_ID] [int] NULL,
 CONSTRAINT [PK__Client__3214EC27BEDE9B0F] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client_Sale]    Script Date: 08.05.2021 17:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client_Sale](
	[Client_ID] [int] NOT NULL,
	[Sale_ID] [int] NOT NULL,
 CONSTRAINT [PK_Client_Sale] PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC,
	[Sale_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 08.05.2021 17:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Price] [decimal](8, 2) NOT NULL,
	[Decription] [nvarchar](40) NULL,
 CONSTRAINT [PK__Item__3214EC27C53E1656] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale_Item]    Script Date: 08.05.2021 17:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Item](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sale_ID] [int] NOT NULL,
	[Item_ID] [int] NOT NULL,
 CONSTRAINT [PK_Sale_Item_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08.05.2021 17:35:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NULL,
	[SurName] [nvarchar](30) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__Users__3214EC277AD24F10] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID], [SurName], [FirstName], [LastName], [User_ID]) VALUES (1, N'Уваров', N'Савелий', N'Игоревич', NULL)
INSERT [dbo].[Client] ([ID], [SurName], [FirstName], [LastName], [User_ID]) VALUES (2, N'Никонов', N'Роберт', N'Максимович', NULL)
INSERT [dbo].[Client] ([ID], [SurName], [FirstName], [LastName], [User_ID]) VALUES (3, N'Кабанов', N'Эльдар', N'Максович', NULL)
INSERT [dbo].[Client] ([ID], [SurName], [FirstName], [LastName], [User_ID]) VALUES (4, N'1', N'1', N'1', NULL)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
INSERT [dbo].[Client_Sale] ([Client_ID], [Sale_ID]) VALUES (1, 1)
INSERT [dbo].[Client_Sale] ([Client_ID], [Sale_ID]) VALUES (2, 2)
INSERT [dbo].[Client_Sale] ([Client_ID], [Sale_ID]) VALUES (3, 3)
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([ID], [Name], [Price], [Decription]) VALUES (1, N'Tea', CAST(13.37 AS Decimal(8, 2)), N'')
INSERT [dbo].[Item] ([ID], [Name], [Price], [Decription]) VALUES (2, N'Chocolate', CAST(420.69 AS Decimal(8, 2)), N'')
INSERT [dbo].[Item] ([ID], [Name], [Price], [Decription]) VALUES (3, N'Apple', CAST(14.88 AS Decimal(8, 2)), N'')
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale_Item] ON 

INSERT [dbo].[Sale_Item] ([ID], [Sale_ID], [Item_ID]) VALUES (1, 1, 1)
INSERT [dbo].[Sale_Item] ([ID], [Sale_ID], [Item_ID]) VALUES (2, 1, 2)
INSERT [dbo].[Sale_Item] ([ID], [Sale_ID], [Item_ID]) VALUES (3, 1, 3)
INSERT [dbo].[Sale_Item] ([ID], [Sale_ID], [Item_ID]) VALUES (4, 2, 2)
INSERT [dbo].[Sale_Item] ([ID], [Sale_ID], [Item_ID]) VALUES (5, 3, 3)
INSERT [dbo].[Sale_Item] ([ID], [Sale_ID], [Item_ID]) VALUES (6, 3, 1)
SET IDENTITY_INSERT [dbo].[Sale_Item] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [SurName], [Login], [Password]) VALUES (1, N'Иванов', N'Иван', N'Петрович', N'LoginPassword', N'Asdcxzaseqw')
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [SurName], [Login], [Password]) VALUES (2, N'Петр', N'Иванович', N'Данилов', N'PasswordLogin', N'VZXcasdasdqw')
INSERT [dbo].[Users] ([ID], [FirstName], [LastName], [SurName], [Login], [Password]) VALUES (3, N'Елизавета', N'Олеговна', N'Пашковская', N'Parol', N'45645adSq')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Users] FOREIGN KEY([User_ID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Users]
GO
ALTER TABLE [dbo].[Client_Sale]  WITH CHECK ADD  CONSTRAINT [FK_Client_Sale_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Client_Sale] CHECK CONSTRAINT [FK_Client_Sale_Client]
GO
ALTER TABLE [dbo].[Client_Sale]  WITH CHECK ADD  CONSTRAINT [FK_Client_Sale_Sale_Item] FOREIGN KEY([Sale_ID])
REFERENCES [dbo].[Sale_Item] ([ID])
GO
ALTER TABLE [dbo].[Client_Sale] CHECK CONSTRAINT [FK_Client_Sale_Sale_Item]
GO
ALTER TABLE [dbo].[Sale_Item]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Item_Item] FOREIGN KEY([Item_ID])
REFERENCES [dbo].[Item] ([ID])
GO
ALTER TABLE [dbo].[Sale_Item] CHECK CONSTRAINT [FK_Sale_Item_Item]
GO
USE [master]
GO
ALTER DATABASE [Homework_DB] SET  READ_WRITE 
GO
