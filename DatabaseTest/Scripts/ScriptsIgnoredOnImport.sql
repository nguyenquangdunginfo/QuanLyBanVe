
USE [master]
GO
ALTER DATABASE [AirTicketDatabase] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AirTicketDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_NULLS OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_PADDING OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ARITHABORT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [AirTicketDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [AirTicketDatabase] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [AirTicketDatabase] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [AirTicketDatabase] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [AirTicketDatabase] SET  DISABLE_BROKER
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [AirTicketDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [AirTicketDatabase] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [AirTicketDatabase] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [AirTicketDatabase] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [AirTicketDatabase] SET RECOVERY SIMPLE
GO
ALTER DATABASE [AirTicketDatabase] SET  MULTI_USER
GO
ALTER DATABASE [AirTicketDatabase] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [AirTicketDatabase] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'AirTicketDatabase', N'ON'
GO
USE [AirTicketDatabase]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[ChangBay]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[ChiTietDatVe]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[HangVe]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[SanBay]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[Account] ([Username], [Password], [Describe]) VALUES (N'admin', N'123', N'System Administrator')
GO
INSERT [dbo].[Account] ([Username], [Password], [Describe]) VALUES (N'Dung', N'123', N'Nguyen Quang Dung')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'BMV-HAN', N'BMV', N'HAN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'BMV-SGN', N'BMV', N'SGN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'HAN-BMV', N'HAN', N'BMV')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'HAN-SGN', N'HAN', N'SGN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-BMV', N'SGN', N'BMV')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-HAN', N'SGN', N'HAN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-VCS', N'SGN', N'VCS')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-VKG', N'SGN', N'VKG')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VCS-SGN', N'VCS', N'SGN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VKG-HUI', N'VKG', N'HUI')
GO
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'241123232', N'Trần Hoài Anh', N'0977565434', N'30 Trần Nhân Tông, Tân Bình')
GO
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'212121346', N'Nguyễn Thùy Linh', N'0978787821', N'10 Trường Sơn, Tân Bình')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DienThoai], [DiaChi]) VALUES (N'241154073', N'Nguyễn Quang Dũng', N'0941884656', N'20 Giải Phóng, Tân Bình')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'BMV', N'Buôn Ma Thuột')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'DAD', N'Đà Nẵng')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'DLI', N'Liên Khương - Đà Lạt')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HAN', N'Nội Bài - Hà Nội')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HPH', N'Cát Bi - Hải Phòng')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HUI', N'Huế')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'SGN', N'Tân Sơn Nhất - TPHCM')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'TBB', N'Tuy Hòa - Phú Yên')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'VCS', N'Côn Sơn - Bà Rịa Vũng Tàu')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'VKG', N'Rạch Giá - Kiên Giang')
GO
USE [master]
GO
ALTER DATABASE [AirTicketDatabase] SET  READ_WRITE
GO
--Syntax Error: Incorrect syntax near CONTAINMENT.
--/****** Object:  Database [AirTicketDatabase]    Script Date: 04/08/2019 12:32:01 AM ******/
--CREATE DATABASE [AirTicketDatabase]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'QuanlyBanVe', FILENAME = N'D:\KIỂM THỬ PHẦN MỀM\ĐỀ TÀI\QuanlyBanVe.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'QuanlyBanVe_log', FILENAME = N'D:\KIỂM THỬ PHẦN MỀM\ĐỀ TÀI\QuanlyBanVe_log.LDF' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)

GO
--Syntax Error: Incorrect syntax near FILESTREAM.
--ALTER DATABASE [AirTicketDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

GO
--Syntax Error: Incorrect syntax near TARGET_RECOVERY_TIME.
--ALTER DATABASE [AirTicketDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 



GO

USE [master]
GO
ALTER DATABASE [AirTicketDatabase] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AirTicketDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_NULLS OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_PADDING OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ARITHABORT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [AirTicketDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [AirTicketDatabase] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [AirTicketDatabase] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [AirTicketDatabase] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [AirTicketDatabase] SET  DISABLE_BROKER
GO
ALTER DATABASE [AirTicketDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [AirTicketDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [AirTicketDatabase] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [AirTicketDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [AirTicketDatabase] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [AirTicketDatabase] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [AirTicketDatabase] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [AirTicketDatabase] SET RECOVERY SIMPLE
GO
ALTER DATABASE [AirTicketDatabase] SET  MULTI_USER
GO
ALTER DATABASE [AirTicketDatabase] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [AirTicketDatabase] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'AirTicketDatabase', N'ON'
GO
USE [AirTicketDatabase]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[ChangBay]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[ChiTietDatVe]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[HangVe]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[SanBay]    Script Date: 04/08/2019 12:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
INSERT [dbo].[Account] ([Username], [Password], [Describe]) VALUES (N'admin', N'123', N'System Administrator')
GO
INSERT [dbo].[Account] ([Username], [Password], [Describe]) VALUES (N'Dung', N'123', N'Nguyen Quang Dung')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'BMV-HAN', N'BMV', N'HAN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'BMV-SGN', N'BMV', N'SGN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'HAN-BMV', N'HAN', N'BMV')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'HAN-SGN', N'HAN', N'SGN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-BMV', N'SGN', N'BMV')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-HAN', N'SGN', N'HAN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-VCS', N'SGN', N'VCS')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-VKG', N'SGN', N'VKG')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VCS-SGN', N'VCS', N'SGN')
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VKG-HUI', N'VKG', N'HUI')
GO
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'241123232', N'Trần Hoài Anh', N'0977565434', N'30 Trần Nhân Tông, Tân Bình')
GO
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'212121346', N'Nguyễn Thùy Linh', N'0978787821', N'10 Trường Sơn, Tân Bình')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DienThoai], [DiaChi]) VALUES (N'241154073', N'Nguyễn Quang Dũng', N'0941884656', N'20 Giải Phóng, Tân Bình')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'BMV', N'Buôn Ma Thuột')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'DAD', N'Đà Nẵng')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'DLI', N'Liên Khương - Đà Lạt')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HAN', N'Nội Bài - Hà Nội')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HPH', N'Cát Bi - Hải Phòng')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HUI', N'Huế')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'SGN', N'Tân Sơn Nhất - TPHCM')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'TBB', N'Tuy Hòa - Phú Yên')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'VCS', N'Côn Sơn - Bà Rịa Vũng Tàu')
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'VKG', N'Rạch Giá - Kiên Giang')
GO
USE [master]
GO
ALTER DATABASE [AirTicketDatabase] SET  READ_WRITE
GO
--Syntax Error: Incorrect syntax near CONTAINMENT.
--/****** Object:  Database [AirTicketDatabase]    Script Date: 04/08/2019 12:32:01 AM ******/
--CREATE DATABASE [AirTicketDatabase]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'QuanlyBanVe', FILENAME = N'D:\KIỂM THỬ PHẦN MỀM\ĐỀ TÀI\QuanlyBanVe.mdf' , SIZE = 3328KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'QuanlyBanVe_log', FILENAME = N'D:\KIỂM THỬ PHẦN MỀM\ĐỀ TÀI\QuanlyBanVe_log.LDF' , SIZE = 3136KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)

GO
--Syntax Error: Incorrect syntax near FILESTREAM.
--ALTER DATABASE [AirTicketDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 

GO
--Syntax Error: Incorrect syntax near TARGET_RECOVERY_TIME.
--ALTER DATABASE [AirTicketDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 



GO
