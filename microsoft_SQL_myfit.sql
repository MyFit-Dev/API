USE [master]
GO

/****** Object:  Database [MyFit]    Script Date: 15/05/2023 21:49:52 ******/
CREATE DATABASE [MyFit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyFit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MyFit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyFit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MyFit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyFit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MyFit] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MyFit] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MyFit] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MyFit] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MyFit] SET ARITHABORT OFF 
GO

ALTER DATABASE [MyFit] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MyFit] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MyFit] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MyFit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MyFit] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MyFit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MyFit] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MyFit] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MyFit] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MyFit] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MyFit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MyFit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MyFit] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MyFit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MyFit] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MyFit] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MyFit] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MyFit] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [MyFit] SET  MULTI_USER 
GO

ALTER DATABASE [MyFit] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MyFit] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MyFit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MyFit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [MyFit] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MyFit] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [MyFit] SET QUERY_STORE = OFF
GO

ALTER DATABASE [MyFit] SET  READ_WRITE 
GO

USE [MyFit]
GO

/****** Object:  Table [MyFit].[dbo].[Plan]    Script Date: 15/05/2023 21:53:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Plan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](32) NOT NULL,
	[Value] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Description] [varchar](400) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](32) NOT NULL,
	[Surname] [varchar](64) NOT NULL,
	[Mail] [varchar](128) NOT NULL,
	[State] [varchar](64) NOT NULL,
	[City] [varchar](64) NOT NULL,
	[IdPlan] [int] NOT NULL,
	[IdGym] [int] NULL,
	[IntermittentFasting] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[User]  WITH CHECK ADD FOREIGN KEY([IdPlan])
REFERENCES [MyFit].[dbo].[Plan] ([Id]) ON DELETE CASCADE; 
GO

/****** Object:  Table [MyFit].[dbo].[StaffType]    Script Date: 15/05/2023 21:54:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[StaffType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MyFit].[dbo].[CustomExercise]    Script Date: 15/05/2023 21:55:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[CustomExercise](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[Method] [varchar](480) NOT NULL,
	[Image] [varchar](64) NOT NULL,
	[Video] [varchar](64) NOT NULL,
	[Duration] [int] NOT NULL,
	[Difficulty] [int] NOT NULL,
	[Calories] [int] NOT NULL,
	[Target] [varchar](255) NOT NULL,
	[Private] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[CustomExercise]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [MyFit].[dbo].[User] ([Id]) ON DELETE CASCADE;
GO

/****** Object:  Table [MyFit].[dbo].[Staff]    Script Date: 15/05/2023 21:56:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[IdType] [int] NOT NULL,
 CONSTRAINT [PK__Staff__3214EC072CC6E257] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([IdType])
REFERENCES [MyFit].[dbo].[StaffType] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MyFit].[dbo].[Staff]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [MyFit].[dbo].[User] ([Id]) ON DELETE CASCADE;
GO

/****** Object:  Table [MyFit].[dbo].[Gym]    Script Date: 15/05/2023 21:57:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Gym](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](54) NOT NULL,
	[IdStaff] [int] NOT NULL,
	[State] [varchar](64) NOT NULL,
	[City] [varchar](64) NOT NULL,
	[Street] [varchar](64) NOT NULL,
	[CivicNumber] [int] NOT NULL,
	[CAP] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[Gym]  WITH CHECK ADD FOREIGN KEY([IdStaff])
REFERENCES [MyFit].[dbo].[Staff] ([Id]) ON DELETE CASCADE;
GO

/****** Object:  Table [MyFit].[dbo].[Record]    Script Date: 15/05/2023 21:58:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Record](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Goal] [varchar](200) NOT NULL,
	[Difficulty] [int] NOT NULL,
	[Reward] [varchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MyFit].[dbo].[DataRecord]    Script Date: 15/05/2023 21:58:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[DataRecord](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdRecord] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
	[Date] [datetime](0) NOT NULL,
 CONSTRAINT [PK_DataRecord] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MyFit].[dbo].[Permission]    Script Date: 15/05/2023 21:59:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Permission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Value] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MyFit].[dbo].[GenericExercise]    Script Date: 15/05/2023 22:00:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[GenericExercise](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[Method] [varchar](480) NOT NULL,
	[Image] [varchar](64) NOT NULL,
	[Video] [varchar](64) NOT NULL,
	[Duration] [int] NOT NULL,
	[Difficulty] [int] NOT NULL,
	[Calories] [int] NOT NULL,
	[Target] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [MyFit].[dbo].[Log]    Script Date: 15/05/2023 22:01:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [varchar](255) NOT NULL,
	[Scope] [varchar](64) NOT NULL,
	[Date] [datetime](0) NOT NULL,
	[IdUser] [int] NOT NULL,
	[Value] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[Log]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [MyFit].[dbo].[User] ([Id]) ON DELETE NO ACTION;
GO

/****** Object:  Table [MyFit].[dbo].[Message]    Script Date: 15/05/2023 22:01:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Message](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [varchar](255) NOT NULL,
	[Date] [datetime](0) NOT NULL,
	[IdSender] [int] NOT NULL,
	[IdRecipient] [int] NOT NULL,
	[Displayed] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[Message]  WITH CHECK ADD FOREIGN KEY([IdRecipient])
REFERENCES [MyFit].[dbo].[User] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [MyFit].[dbo].[Message]  WITH CHECK ADD FOREIGN KEY([IdSender])
REFERENCES [MyFit].[dbo].[User] ([Id]) ON DELETE NO ACTION;
GO

/****** Object:  Table [MyFit].[dbo].[Diet]    Script Date: 15/05/2023 21:51:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Diet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[FoodList] [varchar](500) NOT NULL,
	[Date] [Date](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [MyFit].[dbo].[Diet]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [MyFit].[dbo].[User] ([Id]) ON DELETE CASCADE;
GO

/****** Object:  Table [MyFit].[dbo].[Food]    Script Date: 15/05/2023 22:02:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [MyFit].[dbo].[Food](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](128) NOT NULL,
	[Description] [varchar](255) NOT NULL,
	[Weight] [int] NULL,
	[Calories] [int] NOT NULL,
	[Carbs] [int] NOT NULL,
	[Sugars] [int] NOT NULL,
	[Proteins] [int] NOT NULL,
	[Fats] [int] NOT NULL,
	[Salt] [int] NOT NULL,
	[Magnesium] [int] NOT NULL,
	[Iron] [int] NOT NULL,
	[Potassium] [int] NOT NULL,
	[Image] [varchar](64) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


