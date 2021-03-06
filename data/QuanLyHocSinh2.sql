USE [master]
GO
/****** Object:  Database [QuanLyHocSinh2]    Script Date: 9/18/2018 12:40:30 AM ******/
CREATE DATABASE [QuanLyHocSinh2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHocSinh2', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLyHocSinh2.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyHocSinh2_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QuanLyHocSinh2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyHocSinh2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHocSinh2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHocSinh2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocSinh2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHocSinh2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHocSinh2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyHocSinh2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinh2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHocSinh2] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHocSinh2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHocSinh2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHocSinh2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHocSinh2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyHocSinh2]
GO
/****** Object:  StoredProcedure [dbo].[HienThiChucVu]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienThiChucVu]
AS
SELECT * FROM ChucVu
GO
/****** Object:  StoredProcedure [dbo].[HienThiDanToc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienThiDanToc]
AS
SELECT * FROM DanToc
GO
/****** Object:  StoredProcedure [dbo].[HienThiHanhKiem]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienThiHanhKiem]
AS
SELECT * FROM HanhKiem
GO
/****** Object:  StoredProcedure [dbo].[HienThiHocKi]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienThiHocKi]
AS
SELECT * FROM HocKi
GO
/****** Object:  StoredProcedure [dbo].[SuaChucVu]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaChucVu]
@IDChucVu int,
@TenChucVu nvarchar(50)
AS
UPDATE ChucVu SET TenChucVu = @TenChucVu
				WHERE IDChucVu = @IDChucVu
GO
/****** Object:  StoredProcedure [dbo].[SuaDanToc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDanToc]
@IDDanToc int,
@TenDanToc nvarchar(50)
AS
UPDATE DanToc SET TenDanToc = @TenDanToc
			  WHERE IDDanToc = @IDDanToc 
GO
/****** Object:  StoredProcedure [dbo].[SuaHanhKiem]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaHanhKiem]
@IDHanhKiem int,
@TenHanhKiem nvarchar(50)
AS
UPDATE HanhKiem SET TenHanhKiem=@TenHanhKiem
	WHERE IDHanhKiem=@IDHanhKiem
GO
/****** Object:  StoredProcedure [dbo].[SuaHocKi]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaHocKi]
@IDHocKi int,
@TenHocKi nvarchar(50)
AS
UPDATE HocKi SET TenHocKi=@TenHocKi WHERE IDHocKi=@IDHocKi
GO
/****** Object:  StoredProcedure [dbo].[ThemChucVu]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemChucVu]
	--@IDChucVu int,
	@TenChucVu nvarchar(50)
AS 
INSERT INTO ChucVu (TenChucVu )
	VALUES ( @TenChucVu )
GO
/****** Object:  StoredProcedure [dbo].[ThemDanToc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemDanToc]
@TenDanToc nvarchar(50)
AS
INSERT INTO DanToc (TenDanToc) VALUES (@TenDanToc)
GO
/****** Object:  StoredProcedure [dbo].[ThemHanhKiem]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHanhKiem]
@TenHanhKiem nvarchar(50)
AS
INSERT INTO HanhKiem(TenHanhKiem) VALUES (@TenHanhKiem)
GO
/****** Object:  StoredProcedure [dbo].[ThemHocKi]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHocKi]
@TenHocKi nvarchar(50)
AS
INSERT INTO HocKi (TenHocKi) VALUES (@TenHocKi)
GO
/****** Object:  StoredProcedure [dbo].[XoaChucVu]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaChucVu]
@IDChucVu int
AS
DELETE FROM ChucVu WHERE IDChucVu=@IDChucVu
GO
/****** Object:  StoredProcedure [dbo].[XoaDanToc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaDanToc]
@IDDanToc int
AS
DELETE FROM DanToc WHERE IDDanToc = @IDDanToc
GO
/****** Object:  StoredProcedure [dbo].[XoaHanhKiem]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHanhKiem]
@IDHanhKiem int
AS
DELETE FROM HanhKiem WHERE IDHanhKiem = @IDHanhKiem
GO
/****** Object:  StoredProcedure [dbo].[XoaHocKi]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHocKi]
@IDHocKi int
AS
DELETE  FROM HocKi WHERE IDHocKi = @IDHocKi
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[IDMonHoc] [int] NOT NULL,
	[IDHocSinh] [int] NOT NULL,
	[DiemMieng] [float] NULL,
	[Diem15Phut] [float] NULL,
	[Diem1Tiet] [float] NULL,
	[DiemThi] [float] NULL,
	[DiemTBM] [float] NULL,
 CONSTRAINT [PK_BangDiem] PRIMARY KEY CLUSTERED 
(
	[IDMonHoc] ASC,
	[IDHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[IDChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[IDChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanToc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanToc](
	[IDDanToc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanToc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DanToc] PRIMARY KEY CLUSTERED 
(
	[IDDanToc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[IDGiaoVien] [int] IDENTITY(1,1) NOT NULL,
	[TenGiaoVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[DienThoai] [int] NULL,
	[IDChucVu] [int] NOT NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[IDGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HanhKiem]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HanhKiem](
	[IDHanhKiem] [int] IDENTITY(1,1) NOT NULL,
	[TenHanhKiem] [nvarchar](50) NULL,
 CONSTRAINT [PK_HanhKiem] PRIMARY KEY CLUSTERED 
(
	[IDHanhKiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocKi]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKi](
	[IDHocKi] [int] IDENTITY(1,1) NOT NULL,
	[TenHocKi] [nvarchar](50) NULL,
 CONSTRAINT [PK_HocKi] PRIMARY KEY CLUSTERED 
(
	[IDHocKi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocLuc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocLuc](
	[IDHocLuc] [int] IDENTITY(1,1) NOT NULL,
	[TenHocLuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_HocLuc] PRIMARY KEY CLUSTERED 
(
	[IDHocLuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[IDHocSinh] [int] IDENTITY(1,1) NOT NULL,
	[TenHocSinh] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[NoiSinh] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[IDDanToc] [int] NOT NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KetQuaHocTap]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQuaHocTap](
	[IDHocSinh] [int] NOT NULL,
	[IDNamHoc] [int] NOT NULL,
	[DTBHocKy_I] [float] NOT NULL,
	[DTBHocKy_II] [float] NOT NULL,
	[DTBCaNam] [float] NOT NULL,
	[IDHanhKiem] [int] NOT NULL,
	[IDHocLuc] [int] NOT NULL,
 CONSTRAINT [PK_KetQuaHocTap] PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC,
	[IDNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoiLop]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoiLop](
	[IDKhoi] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhoiLop] PRIMARY KEY CLUSTERED 
(
	[IDKhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[IDLopHoc] [int] IDENTITY(1,1) NOT NULL,
	[TenLopHoc] [nvarchar](50) NULL,
	[SiSo] [int] NULL,
	[IDKhoi] [int] NOT NULL,
	[IDGiaoVien] [int] NOT NULL,
	[IDNamHoc] [int] NOT NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[IDLopHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[IDMonHoc] [int] IDENTITY(1,1) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
	[IDHocKi] [int] NOT NULL,
	[IDKhoi] [int] NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[IDMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NamHoc]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NamHoc](
	[IDNamHoc] [int] IDENTITY(1,1) NOT NULL,
	[TenNamHoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_NamHoc] PRIMARY KEY CLUSTERED 
(
	[IDNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[IDMonHoc] [int] NOT NULL,
	[IDLopHoc] [int] NOT NULL,
	[IDGiaoVien] [int] NOT NULL,
	[IDNamHoc] [int] NOT NULL,
 CONSTRAINT [PK_PhanCong_1] PRIMARY KEY CLUSTERED 
(
	[IDMonHoc] ASC,
	[IDLopHoc] ASC,
	[IDGiaoVien] ASC,
	[IDNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanLop]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLop](
	[IDHocSinh] [int] NOT NULL,
	[IDLopHoc] [int] NOT NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[IDHocSinh] ASC,
	[IDLopHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuiDinh]    Script Date: 9/18/2018 12:40:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuiDinh](
	[IDQuiDinh] [int] IDENTITY(1,1) NOT NULL,
	[TuoiToiThieu] [int] NULL,
	[TuoiToiDa] [int] NULL,
	[SiSoToiDa] [int] NULL,
	[DiemChuan] [float] NULL,
	[SoLuongLop] [int] NULL,
	[SoMonHoc] [int] NULL,
	[TenTruong] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuiDinh] PRIMARY KEY CLUSTERED 
(
	[IDQuiDinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([IDChucVu], [TenChucVu]) VALUES (2, N'Giáo Viên')
INSERT [dbo].[ChucVu] ([IDChucVu], [TenChucVu]) VALUES (3, N'Bác Sĩ')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
SET IDENTITY_INSERT [dbo].[DanToc] ON 

INSERT [dbo].[DanToc] ([IDDanToc], [TenDanToc]) VALUES (2, N'Thái')
SET IDENTITY_INSERT [dbo].[DanToc] OFF
SET IDENTITY_INSERT [dbo].[HanhKiem] ON 

INSERT [dbo].[HanhKiem] ([IDHanhKiem], [TenHanhKiem]) VALUES (2, N'Giỏi')
SET IDENTITY_INSERT [dbo].[HanhKiem] OFF
SET IDENTITY_INSERT [dbo].[HocKi] ON 

INSERT [dbo].[HocKi] ([IDHocKi], [TenHocKi]) VALUES (1, N'Học kì I')
INSERT [dbo].[HocKi] ([IDHocKi], [TenHocKi]) VALUES (2, N'Học kì II')
SET IDENTITY_INSERT [dbo].[HocKi] OFF
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocSinh] FOREIGN KEY([IDHocSinh])
REFERENCES [dbo].[HocSinh] ([IDHocSinh])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocSinh]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_MonHoc] FOREIGN KEY([IDMonHoc])
REFERENCES [dbo].[MonHoc] ([IDMonHoc])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_MonHoc]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_ChucVu] FOREIGN KEY([IDChucVu])
REFERENCES [dbo].[ChucVu] ([IDChucVu])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_ChucVu]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_DanToc] FOREIGN KEY([IDDanToc])
REFERENCES [dbo].[DanToc] ([IDDanToc])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_DanToc]
GO
ALTER TABLE [dbo].[KetQuaHocTap]  WITH CHECK ADD  CONSTRAINT [FK_KetQuaHocTap_HanhKiem] FOREIGN KEY([IDHanhKiem])
REFERENCES [dbo].[HanhKiem] ([IDHanhKiem])
GO
ALTER TABLE [dbo].[KetQuaHocTap] CHECK CONSTRAINT [FK_KetQuaHocTap_HanhKiem]
GO
ALTER TABLE [dbo].[KetQuaHocTap]  WITH CHECK ADD  CONSTRAINT [FK_KetQuaHocTap_HocLuc] FOREIGN KEY([IDHocLuc])
REFERENCES [dbo].[HocLuc] ([IDHocLuc])
GO
ALTER TABLE [dbo].[KetQuaHocTap] CHECK CONSTRAINT [FK_KetQuaHocTap_HocLuc]
GO
ALTER TABLE [dbo].[KetQuaHocTap]  WITH CHECK ADD  CONSTRAINT [FK_KetQuaHocTap_HocSinh] FOREIGN KEY([IDHocSinh])
REFERENCES [dbo].[HocSinh] ([IDHocSinh])
GO
ALTER TABLE [dbo].[KetQuaHocTap] CHECK CONSTRAINT [FK_KetQuaHocTap_HocSinh]
GO
ALTER TABLE [dbo].[KetQuaHocTap]  WITH CHECK ADD  CONSTRAINT [FK_KetQuaHocTap_NamHoc] FOREIGN KEY([IDNamHoc])
REFERENCES [dbo].[NamHoc] ([IDNamHoc])
GO
ALTER TABLE [dbo].[KetQuaHocTap] CHECK CONSTRAINT [FK_KetQuaHocTap_NamHoc]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_GiaoVien] FOREIGN KEY([IDGiaoVien])
REFERENCES [dbo].[GiaoVien] ([IDGiaoVien])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_GiaoVien]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_KhoiLop] FOREIGN KEY([IDKhoi])
REFERENCES [dbo].[KhoiLop] ([IDKhoi])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_KhoiLop]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_NamHoc] FOREIGN KEY([IDNamHoc])
REFERENCES [dbo].[NamHoc] ([IDNamHoc])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_NamHoc]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_HocKi] FOREIGN KEY([IDHocKi])
REFERENCES [dbo].[HocKi] ([IDHocKi])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_HocKi]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_KhoiLop] FOREIGN KEY([IDKhoi])
REFERENCES [dbo].[KhoiLop] ([IDKhoi])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_KhoiLop]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_GiaoVien] FOREIGN KEY([IDGiaoVien])
REFERENCES [dbo].[GiaoVien] ([IDGiaoVien])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_GiaoVien]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_LopHoc] FOREIGN KEY([IDLopHoc])
REFERENCES [dbo].[LopHoc] ([IDLopHoc])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_LopHoc]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_MonHoc] FOREIGN KEY([IDMonHoc])
REFERENCES [dbo].[MonHoc] ([IDMonHoc])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_MonHoc]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_NamHoc] FOREIGN KEY([IDNamHoc])
REFERENCES [dbo].[NamHoc] ([IDNamHoc])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_NamHoc]
GO
ALTER TABLE [dbo].[PhanLop]  WITH CHECK ADD  CONSTRAINT [FK_PhanLop_HocSinh] FOREIGN KEY([IDHocSinh])
REFERENCES [dbo].[HocSinh] ([IDHocSinh])
GO
ALTER TABLE [dbo].[PhanLop] CHECK CONSTRAINT [FK_PhanLop_HocSinh]
GO
ALTER TABLE [dbo].[PhanLop]  WITH CHECK ADD  CONSTRAINT [FK_PhanLop_LopHoc] FOREIGN KEY([IDLopHoc])
REFERENCES [dbo].[LopHoc] ([IDLopHoc])
GO
ALTER TABLE [dbo].[PhanLop] CHECK CONSTRAINT [FK_PhanLop_LopHoc]
GO
USE [master]
GO
ALTER DATABASE [QuanLyHocSinh2] SET  READ_WRITE 
GO
