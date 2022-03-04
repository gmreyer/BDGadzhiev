USE [master]
GO
/****** Object:  Database [TobaccoFact]    Script Date: 04.03.2022 19:57:17 ******/
CREATE DATABASE [TobaccoFact]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TobaccoFact', FILENAME = N'D:\BD\TobaccoFact.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TobaccoFact_log', FILENAME = N'D:\BD\TobaccoFact_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TobaccoFact] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TobaccoFact].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TobaccoFact] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TobaccoFact] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TobaccoFact] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TobaccoFact] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TobaccoFact] SET ARITHABORT OFF 
GO
ALTER DATABASE [TobaccoFact] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TobaccoFact] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TobaccoFact] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TobaccoFact] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TobaccoFact] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TobaccoFact] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TobaccoFact] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TobaccoFact] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TobaccoFact] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TobaccoFact] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TobaccoFact] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TobaccoFact] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TobaccoFact] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TobaccoFact] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TobaccoFact] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TobaccoFact] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TobaccoFact] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TobaccoFact] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TobaccoFact] SET  MULTI_USER 
GO
ALTER DATABASE [TobaccoFact] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TobaccoFact] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TobaccoFact] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TobaccoFact] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TobaccoFact] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TobaccoFact] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TobaccoFact', N'ON'
GO
ALTER DATABASE [TobaccoFact] SET QUERY_STORE = OFF
GO
USE [TobaccoFact]
GO
/****** Object:  User [gmreyer]    Script Date: 04.03.2022 19:57:17 ******/
CREATE USER [gmreyer] FOR LOGIN [gmreyer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[id_brand] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[id_brand] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Markets]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Markets](
	[id_market] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Markets] PRIMARY KEY CLUSTERED 
(
	[id_market] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[id_worker] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[id_market] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[id_post] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[id_post] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[id_tobacco] [int] NOT NULL,
	[id_brand] [int] NOT NULL,
	[price] [money] NOT NULL,
	[gramm] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tobacco]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tobacco](
	[id_tobacco] [int] IDENTITY(1,1) NOT NULL,
	[taste] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[strength] [nvarchar](50) NOT NULL,
	[country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id_tobacco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[id_product] [int] NOT NULL,
	[quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[id_worker] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[salary] [int] NOT NULL,
	[age] [int] NOT NULL,
	[id_post] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[id_worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Markets] FOREIGN KEY([id_market])
REFERENCES [dbo].[Markets] ([id_market])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Markets]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Product] FOREIGN KEY([id_product])
REFERENCES [dbo].[Product] ([id_product])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Product]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Worker] FOREIGN KEY([id_worker])
REFERENCES [dbo].[Worker] ([id_worker])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Worker]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Brand] FOREIGN KEY([id_brand])
REFERENCES [dbo].[Brand] ([id_brand])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Brand]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Tobacco] FOREIGN KEY([id_tobacco])
REFERENCES [dbo].[Tobacco] ([id_tobacco])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Tobacco]
GO
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Product] FOREIGN KEY([id_product])
REFERENCES [dbo].[Product] ([id_product])
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_Product]
GO
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD  CONSTRAINT [FK_Worker_Post] FOREIGN KEY([id_post])
REFERENCES [dbo].[Post] ([id_post])
GO
ALTER TABLE [dbo].[Worker] CHECK CONSTRAINT [FK_Worker_Post]
GO
/****** Object:  StoredProcedure [dbo].[getByPassword]    Script Date: 04.03.2022 19:57:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getByPassword](@login nvarchar(50))
as
begin
	select Worker.password, 
	Worker.id_worker, 
	Worker.id_post, 
	Worker.name as WorkerName, 
	Post.name as PostName,  
	Worker.age, 
	Worker.salary from Worker, Post 
	where Worker.login = @login and Worker.id_post = Post.id_post
end

GO
USE [master]
GO
ALTER DATABASE [TobaccoFact] SET  READ_WRITE 
GO
