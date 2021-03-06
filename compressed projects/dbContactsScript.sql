USE [master]
GO
/****** Object:  Database [dbContacts]    Script Date: 10/4/2021 1:20:46 AM ******/
CREATE DATABASE [dbContacts] ON  PRIMARY 
( NAME = N'dbContacts', FILENAME = N'F:\OnionContactManagementSolution\dbContacts.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbContacts_log', FILENAME = N'F:\OnionContactManagementSolution\dbContacts_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbContacts] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbContacts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbContacts] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbContacts] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbContacts] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbContacts] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbContacts] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbContacts] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbContacts] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbContacts] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbContacts] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbContacts] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbContacts] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbContacts] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbContacts] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbContacts] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbContacts] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbContacts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbContacts] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbContacts] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbContacts] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbContacts] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbContacts] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbContacts] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbContacts] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbContacts] SET  MULTI_USER 
GO
ALTER DATABASE [dbContacts] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbContacts] SET DB_CHAINING OFF 
GO
USE [dbContacts]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 10/4/2021 1:20:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[CustId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Status] [nvarchar](5) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (2, N'test1f_N_N', N'test1l', N'test1@test.test', N'9876654', N'N')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (3, N'test2F', N'Test2L', N'test2@test.test', N'9876543274', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (4, N'test3f', N'test3l', N'test3@test.test', N'87748569853', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (5, N'test4f', N'test4l', N'test3@test.test', N'97748569853', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (6, N'test5f', N'test5l', N'test5@test.test', N'9837475833', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (7, N'test5f', N'test5l', N'test5@test.test', N'9837475833', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (8, N'test5f', N'test5l', N'test5@test.test', N'9837475833', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (9, N'test6f', N'test6l', N'test6@test.test', N'9632574125', N'A')
INSERT [dbo].[Contacts] ([CustId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (10, N'test7f', N'test7l', N'test7@test.test', N'96358745632', N'A')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
USE [master]
GO
ALTER DATABASE [dbContacts] SET  READ_WRITE 
GO
