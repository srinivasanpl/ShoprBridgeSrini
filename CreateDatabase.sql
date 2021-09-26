USE [master]
GO

/****** Object:  Database [ShopBridge]    Script Date: 26/09/21 00:42:51 ******/
CREATE DATABASE [ShopBridge]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopBridge', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER02\MSSQL\DATA\ShopBridge.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopBridge_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER02\MSSQL\DATA\ShopBridge_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopBridge].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ShopBridge] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ShopBridge] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ShopBridge] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ShopBridge] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ShopBridge] SET ARITHABORT OFF 
GO

ALTER DATABASE [ShopBridge] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ShopBridge] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ShopBridge] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ShopBridge] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ShopBridge] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ShopBridge] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ShopBridge] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ShopBridge] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ShopBridge] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ShopBridge] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ShopBridge] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ShopBridge] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ShopBridge] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ShopBridge] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ShopBridge] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ShopBridge] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ShopBridge] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ShopBridge] SET RECOVERY FULL 
GO

ALTER DATABASE [ShopBridge] SET  MULTI_USER 
GO

ALTER DATABASE [ShopBridge] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ShopBridge] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ShopBridge] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ShopBridge] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ShopBridge] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ShopBridge] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ShopBridge] SET  READ_WRITE 
GO

