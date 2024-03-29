USE [master]
GO
/****** Object:  Database [TobaccoFact]    Script Date: 27.03.2022 16:30:22 ******/
CREATE DATABASE [TobaccoFact]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TobaccoFact', FILENAME = N'D:\MSSQLServer\MSSQL15.MSSQLSERVER\MSSQL\DATA\TobaccoFact.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TobaccoFact_log', FILENAME = N'D:\MSSQLServer\MSSQL15.MSSQLSERVER\MSSQL\DATA\TobaccoFact_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  User [test]    Script Date: 27.03.2022 16:30:22 ******/
CREATE USER [test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 27.03.2022 16:30:23 ******/
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
/****** Object:  Table [dbo].[Markets]    Script Date: 27.03.2022 16:30:23 ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 27.03.2022 16:30:23 ******/
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
/****** Object:  Table [dbo].[Post]    Script Date: 27.03.2022 16:30:23 ******/
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
/****** Object:  Table [dbo].[Product]    Script Date: 27.03.2022 16:30:23 ******/
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
/****** Object:  Table [dbo].[ProductionOrder]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionOrder](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
	[id_warehouse] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[id_worker] [int] NOT NULL,
 CONSTRAINT [PK_ProductionOrder] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tobacco]    Script Date: 27.03.2022 16:30:23 ******/
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
/****** Object:  Table [dbo].[Warehouse]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[id_warehouse] [int] IDENTITY(1,1) NOT NULL,
	[id_product] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[id_warehouse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 27.03.2022 16:30:23 ******/
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
ALTER TABLE [dbo].[ProductionOrder]  WITH CHECK ADD  CONSTRAINT [FK_ProductionOrder_Warehouse] FOREIGN KEY([id_warehouse])
REFERENCES [dbo].[Warehouse] ([id_warehouse])
GO
ALTER TABLE [dbo].[ProductionOrder] CHECK CONSTRAINT [FK_ProductionOrder_Warehouse]
GO
ALTER TABLE [dbo].[ProductionOrder]  WITH CHECK ADD  CONSTRAINT [FK_ProductionOrder_Worker] FOREIGN KEY([id_worker])
REFERENCES [dbo].[Worker] ([id_worker])
GO
ALTER TABLE [dbo].[ProductionOrder] CHECK CONSTRAINT [FK_ProductionOrder_Worker]
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
/****** Object:  StoredProcedure [dbo].[AcceptProductionRequest]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AcceptProductionRequest]
	@id_order int
as
begin
	declare @quantity int
	select @quantity = ProductionOrder.quantity from ProductionOrder where ProductionOrder.id_order = @id_order
	
	declare @id_warehouse int
	select @id_warehouse = ProductionOrder.id_warehouse from ProductionOrder where ProductionOrder.id_order = @id_order
	
	update Warehouse set Warehouse.quantity = @quantity where Warehouse.id_warehouse = @id_warehouse

	delete from ProductionOrder where ProductionOrder.id_order = @id_order
end
GO
/****** Object:  StoredProcedure [dbo].[AddBrand]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddBrand]
	@name nvarchar(50),
	@country nvarchar(50)
as
begin
	insert into Brand (Brand.name, country) values (@name, @country)
end
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddProduct]
	@id_tobacco int,
	@id_brand int,
	@price money,
	@gramm int
as
begin
	insert into Product (id_tobacco, id_brand, price, gramm) values (@id_tobacco, @id_brand, @price, @gramm)
end
GO
/****** Object:  StoredProcedure [dbo].[AddRequest]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddRequest]
@id_worker as int,
@id_warehouse as int,
@quantity as int
as
begin
	insert into ProductionOrder (id_warehouse, id_worker, quantity) values (@id_warehouse, @id_worker, @quantity)
end
GO
/****** Object:  StoredProcedure [dbo].[AddTobacco]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddTobacco]
	@taste nvarchar(50),
	@type nvarchar(50),
	@strength int,
	@country nvarchar(50)
as
begin
	insert into Tobacco (taste, Tobacco.type, strength, country) values (@taste, @type, @strength, @country)
end
GO
/****** Object:  StoredProcedure [dbo].[AddWarehouseSlot]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddWarehouseSlot]
@id_product as int,
@quantity as int
as
begin
	insert into Warehouse (Warehouse.id_product, Warehouse.quantity) values (@id_product, @quantity)
end
GO
/****** Object:  StoredProcedure [dbo].[CreateMarket]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CreateMarket]
@name as nvarchar(50),
@city as nvarchar(50)
as
begin
	insert into Markets (Markets.name, Markets.city) values (@name, @city) 
end
GO
/****** Object:  StoredProcedure [dbo].[CreateOrder]    Script Date: 27.03.2022 16:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CreateOrder]
@id_product as int,
@id_market as int,
@id_worker as int
as
begin
	insert into [Order] ([Order].id_product, [Order].id_market, [Order].id_worker) values (@id_product, @id_market, @id_worker)
end
GO
/****** Object:  StoredProcedure [dbo].[getByPassword]    Script Date: 27.03.2022 16:30:23 ******/
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
