USE [master]
GO
/****** Object:  Database [TeachICTU]    Script Date: 12/1/2022 10:58:07 PM ******/
CREATE DATABASE [TeachICTU]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TeachICTU', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER1\MSSQL\DATA\TeachICTU.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TeachICTU_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER1\MSSQL\DATA\TeachICTU_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TeachICTU] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TeachICTU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TeachICTU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TeachICTU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TeachICTU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TeachICTU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TeachICTU] SET ARITHABORT OFF 
GO
ALTER DATABASE [TeachICTU] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TeachICTU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TeachICTU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TeachICTU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TeachICTU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TeachICTU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TeachICTU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TeachICTU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TeachICTU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TeachICTU] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TeachICTU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TeachICTU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TeachICTU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TeachICTU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TeachICTU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TeachICTU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TeachICTU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TeachICTU] SET RECOVERY FULL 
GO
ALTER DATABASE [TeachICTU] SET  MULTI_USER 
GO
ALTER DATABASE [TeachICTU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TeachICTU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TeachICTU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TeachICTU] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TeachICTU] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TeachICTU] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TeachICTU', N'ON'
GO
ALTER DATABASE [TeachICTU] SET QUERY_STORE = OFF
GO
USE [TeachICTU]
GO
/****** Object:  Table [dbo].[diem]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diem](
	[id] [uniqueidentifier] NULL,
	[id_user] [uniqueidentifier] NULL,
	[id_monhoc] [uniqueidentifier] NULL,
	[id_khoa_hoc] [uniqueidentifier] NULL,
	[diemheso1] [float] NULL,
	[diemheso2] [float] NULL,
	[diemTb] [float] NULL,
	[nguoitao] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa_hoc]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa_hoc](
	[id] [uniqueidentifier] NOT NULL,
	[ten_khoa_hoc] [nvarchar](50) NULL,
	[thoi_gian_bat_dau] [date] NULL,
	[thoi_gian_ket_thuc] [date] NULL,
	[giao_vien] [nvarchar](50) NULL,
	[link_hoc] [nvarchar](50) NULL,
	[phan_mem_hoc] [nvarchar](50) NULL,
	[trang_thai] [bit] NULL,
	[nguoi_tao] [nvarchar](50) NULL,
	[id_mon_hoc] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id] [uniqueidentifier] NOT NULL,
	[user_name] [nvarchar](50) NULL,
	[password] [nvarchar](512) NULL,
	[type_user] [int] NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monhoc]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monhoc](
	[id] [uniqueidentifier] NOT NULL,
	[ma_mon_hoc] [nvarchar](50) NULL,
	[ten_mon_hoc] [nvarchar](50) NULL,
	[lop_hoc_phan] [nvarchar](50) NULL,
	[so_tin_chi] [int] NULL,
	[khoa_hoc] [nvarchar](10) NULL,
	[hoc_ki] [nvarchar](10) NULL,
	[thoi_gian_day] [datetime] NULL,
	[trang_thai] [bit] NULL,
 CONSTRAINT [PK_monhoc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phong_hoc]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phong_hoc](
	[id] [uniqueidentifier] NULL,
	[ten_phong_hoc] [nvarchar](50) NULL,
	[trang_thai] [bit] NULL,
	[nguoi_tao] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[id] [uniqueidentifier] NOT NULL,
	[class_name] [nvarchar](50) NULL,
	[he_dao_tao] [nvarchar](50) NULL,
	[khoa_hoc] [nvarchar](10) NULL,
	[id_user] [uniqueidentifier] NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[teacher]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teacher](
	[ma_giao_vien] [uniqueidentifier] NOT NULL,
	[bo_phan] [nvarchar](50) NULL,
	[chuyen_nganh] [nvarchar](50) NULL,
	[id_user] [uniqueidentifier] NULL,
 CONSTRAINT [PK_teacher] PRIMARY KEY CLUSTERED 
(
	[ma_giao_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/1/2022 10:58:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[birthday] [datetime] NULL,
	[CCCD_CMT] [nvarchar](20) NOT NULL,
	[phone] [nvarchar](10) NULL,
	[place_of_birth] [nvarchar](50) NULL,
	[create_by] [nvarchar](30) NULL,
	[create_time] [datetime] NULL,
	[IdLogin] [uniqueidentifier] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[diem] ADD  CONSTRAINT [DF_diem_nguoitao]  DEFAULT (newid()) FOR [nguoitao]
GO
ALTER TABLE [dbo].[khoa_hoc] ADD  CONSTRAINT [DF_khoa_hoc_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[login] ADD  CONSTRAINT [DF_login_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[monhoc] ADD  CONSTRAINT [DF_monhoc_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[student] ADD  CONSTRAINT [DF_student_id]  DEFAULT (newid()) FOR [id]
GO
ALTER TABLE [dbo].[teacher] ADD  CONSTRAINT [DF_teacher_ma_giao_vien]  DEFAULT (newid()) FOR [ma_giao_vien]
GO
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [DF_users_id]  DEFAULT (newid()) FOR [id]
GO
USE [master]
GO
ALTER DATABASE [TeachICTU] SET  READ_WRITE 
GO
