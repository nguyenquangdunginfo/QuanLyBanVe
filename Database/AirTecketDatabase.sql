USE [AirTicketDatabase]
GO
/****** Object:  Table [dbo].[SanBay]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanBay](
	[MaSanBay] [nvarchar](10) NOT NULL,
	[TenSanBay] [nvarchar](255) NULL,
 CONSTRAINT [PK_SanBay] PRIMARY KEY CLUSTERED 
(
	[MaSanBay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'BMV', N'Buôn Ma Thuột')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'DAD', N'Đà Nẵng')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'DLI', N'Liên Khương - Đà Lạt')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HAN', N'Nội Bài - Hà Nội')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HPH', N'Cát Bi - Hải Phòng')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'HUI', N'Huế')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'SGN', N'Tân Sơn Nhất - TPHCM')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'TBB', N'Tuy Hòa - Phú Yên')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'VCS', N'Côn Sơn - Bà Rịa Vũng Tàu')
INSERT [dbo].[SanBay] ([MaSanBay], [TenSanBay]) VALUES (N'VKG', N'Rạch Giá - Kiên Giang')
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[DiaChi] [nvarchar](255) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DienThoai], [DiaChi]) VALUES (N'241154073', N'Nguyễn Quang Dũng', N'0941884656', N'20 Giải Phóng, Tân Bình')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [nvarchar](20) NOT NULL,
	[TenKH] [nvarchar](255) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[DiaChi] [nvarchar](250) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'241123232', N'Trần Hoài Anh', N'0977565434', N'30 Trần Nhân Tông, Tân Bình')
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'212121346', N'Nguyễn Thùy Linh', N'0978787821', N'10 Trường Sơn, Tân Bình')
INSERT [dbo].[KhachHang] ([CMND], [TenKH], [DienThoai], [DiaChi]) VALUES (N'123', N'ad', N'123', N'111abc')
/****** Object:  Table [dbo].[HangVe]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangVe](
	[MaHangVe] [nvarchar](10) NOT NULL,
	[TenHangVe] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangVe] PRIMARY KEY CLUSTERED 
(
	[MaHangVe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDatVe]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatVe](
	[SanBayDi] [nvarchar](150) NULL,
	[SanBayDen] [nvarchar](150) NULL,
	[ThoiGian] [nvarchar](150) NULL,
	[HangVe] [nvarchar](150) NULL,
	[SoLuong] [nvarchar](150) NULL,
	[CMND] [nvarchar](150) NULL,
	[HoTenKH] [nvarchar](150) NULL,
	[NamSinh] [nvarchar](150) NULL,
	[SoDienThoai] [nvarchar](150) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[TongTienVe] [nvarchar](150) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDatVe] ([SanBayDi], [SanBayDen], [ThoiGian], [HangVe], [SoLuong], [CMND], [HoTenKH], [NamSinh], [SoDienThoai], [DiaChi], [TongTienVe]) VALUES (N'Buôn Ma Thuột', N'HAN', N'04/04/2019', N'Economy', N'2', N'241154073', N'Nguyen Quang Dung', N'1989', N'0941884656', N'20 Giải Phóng, Tân Bình', N'4000000 VND')
INSERT [dbo].[ChiTietDatVe] ([SanBayDi], [SanBayDen], [ThoiGian], [HangVe], [SoLuong], [CMND], [HoTenKH], [NamSinh], [SoDienThoai], [DiaChi], [TongTienVe]) VALUES (N'Côn Sơn - Bà Rịa Vũng Tàu', N'SGN', N'04/10/2019', N'Economy', N'3', N'241154245', N'Trần Khánh Ly', N'1990', N'0941884656', N'30 Hoàng Văn Thụ, Tân Bình', N'6000000 VND')
/****** Object:  Table [dbo].[ChangBay]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChangBay](
	[MaChangBay] [nvarchar](20) NOT NULL,
	[MaSanBayDi] [nvarchar](10) NULL,
	[MaSanBayDen] [nvarchar](10) NULL,
 CONSTRAINT [PK_ChangBay] PRIMARY KEY CLUSTERED 
(
	[MaChangBay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'BMV-HAN', N'BMV', N'HAN')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'BMV-SGN', N'BMV', N'SGN')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'HAN-BMV', N'HAN', N'BMV')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'HAN-SGN', N'HAN', N'SGN')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-BMV', N'SGN', N'BMV')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-HAN', N'SGN', N'HAN')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-VCS', N'SGN', N'VCS')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'SGN-VKG', N'SGN', N'VKG')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VCS-SGN', N'VCS', N'SGN')
INSERT [dbo].[ChangBay] ([MaChangBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'VKG-HUI', N'VKG', N'HUI')
/****** Object:  Table [dbo].[Account]    Script Date: 04/10/2019 20:59:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](10) NULL,
	[Describe] [nvarchar](250) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([Username], [Password], [Describe]) VALUES (N'admin', N'123', N'System Administrator')
INSERT [dbo].[Account] ([Username], [Password], [Describe]) VALUES (N'Dung', N'123', N'Nguyen Quang Dung')
