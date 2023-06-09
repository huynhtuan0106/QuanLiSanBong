Create database Sanbong;
go

USE [SanBong]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[MaHD] [int] NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[SoLuong] [float] NULL,
	[ThanhTien] [float] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NULL,
	[MaSan] [int] NULL,
	[GioVao] [datetime] NULL,
	[GioRa] [datetime] NULL,
	[TongTien] [float] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[Phone] [char](15) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[username] [nchar](50) NULL,
	[password] [nchar](50) NULL,
	[phone] [nchar](15) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLy]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLy](
	[MaQL] [int] IDENTITY(1,1) NOT NULL,
	[TenQL] [nvarchar](50) NULL,
	[username] [char](50) NULL,
	[password] [char](50) NULL,
	[phone] [char](15) NULL,
 CONSTRAINT [PK_QuanLy] PRIMARY KEY CLUSTERED 
(
	[MaQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San](
	[MaSan] [int] NOT NULL,
	[TenSan] [nvarchar](20) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_San] PRIMARY KEY CLUSTERED 
(
	[MaSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/5/2022 10:05:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'2CT2      ', 1, 200000, 200000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'3BM       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'3BN       ', 3, 30000, 10000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'3HT       ', 1, 25000, 25000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'3KL       ', 1, 4000, 4000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'3MG       ', 1, 6000, 6000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (1, N'3TD       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (2, N'2CT2      ', 5.5, 1100000, 200000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (2, N'3BM       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (2, N'3BN       ', 1, 10000, 10000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (2, N'3KL       ', 1, 4000, 4000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (2, N'3MG       ', 1, 6000, 6000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'2CT1      ', 2, 340000, 170000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'3BM       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'3BN       ', 1, 10000, 10000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'3KL       ', 1, 4000, 4000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'3MG       ', 1, 6000, 6000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'3NS       ', 1, 10000, 10000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (3, N'3TD       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (4, N'2CT1      ', 4, 680000, 170000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (4, N'3KL       ', 2, 8000, 4000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (4, N'3MG       ', 1, 6000, 6000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (4, N'3NS       ', 1, 10000, 10000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (4, N'3TD       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (5, N'1NT2      ', 0.5, 90000, 180000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'1NT1      ', 3, 450000, 150000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'1NT2      ', 5.5, 990000, 180000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'3BM       ', 1, 15000, 15000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'3BN       ', 1, 10000, 10000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'3KL       ', 1, 4000, 4000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'3MG       ', 2, 12000, 6000)
INSERT [dbo].[ChiTietHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien], [DonGia]) VALUES (6, N'3NS       ', 1, 10000, 10000)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaSan], [GioVao], [GioRa], [TongTien], [TrangThai]) VALUES (1, 1, 1, CAST(N'2022-12-03T20:05:10.000' AS DateTime), CAST(N'2022-12-03T21:00:00.000' AS DateTime), 295000, 1)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaSan], [GioVao], [GioRa], [TongTien], [TrangThai]) VALUES (2, 2, 2, CAST(N'2022-12-03T15:05:19.000' AS DateTime), CAST(N'2022-12-03T20:09:02.000' AS DateTime), 1135000, 1)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaSan], [GioVao], [GioRa], [TongTien], [TrangThai]) VALUES (3, 4, 3, CAST(N'2022-12-03T12:05:48.000' AS DateTime), CAST(N'2022-12-03T14:00:00.000' AS DateTime), 400000, 1)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaSan], [GioVao], [GioRa], [TongTien], [TrangThai]) VALUES (4, 3, 4, CAST(N'2022-12-03T08:06:58.000' AS DateTime), CAST(N'2022-12-03T12:00:00.000' AS DateTime), 719000, 1)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaSan], [GioVao], [GioRa], [TongTien], [TrangThai]) VALUES (5, 1, 1, CAST(N'2022-12-05T20:01:11.000' AS DateTime), CAST(N'2022-12-05T20:01:17.000' AS DateTime), 90000, 1)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaSan], [GioVao], [GioRa], [TongTien], [TrangThai]) VALUES (6, 2, 2, CAST(N'2022-12-05T12:27:09.000' AS DateTime), CAST(N'2022-12-05T20:27:26.000' AS DateTime), 1491000, 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Phone]) VALUES (1, N'Nguyễn Văn An', N'0848122611     ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Phone]) VALUES (2, N'Trần Thị Thảo', N'0564681751     ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Phone]) VALUES (3, N'Lê  Thành Chí', N'0125582114     ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Phone]) VALUES (4, N'Võ Gia Phát', N'0943528019     ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Phone]) VALUES (5, N'Lý Cẩm Hướng', N'0943546023     ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Phone]) VALUES (6, N'Trần Thị Trúc Phương', N'0978912345     ')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [username], [password], [phone]) VALUES (1, N'Huỳnh Anh Tuấn', N'tuan123                                           ', N'123456                                            ', N'0848122611     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [username], [password], [phone]) VALUES (2, N'Thái Gia Bảo', N'bao123                                            ', N'123456                                            ', N'0564681751     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [username], [password], [phone]) VALUES (3, N'Nguyễn Văn A', N'vana123                                           ', N'1234567                                           ', N'0943528019     ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [username], [password], [phone]) VALUES (5, N'Nguyễn Văn B', N'vanb123                                           ', N'123456                                            ', N'0946587135     ')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[QuanLy] ON 

INSERT [dbo].[QuanLy] ([MaQL], [TenQL], [username], [password], [phone]) VALUES (1, N'Huỳnh Anh Tuấn', N'tuan1234                                          ', N'123456                                            ', N'0848122611     ')
INSERT [dbo].[QuanLy] ([MaQL], [TenQL], [username], [password], [phone]) VALUES (2, N'Thái Gia Bảo', N'bao1234                                           ', N'123456                                            ', N'0564681751     ')
SET IDENTITY_INSERT [dbo].[QuanLy] OFF
GO
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai]) VALUES (1, N'Sân 1', 0)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai]) VALUES (2, N'Sân 2', 0)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai]) VALUES (3, N'Sân 3', 0)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai]) VALUES (4, N'Sân 4', 0)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai]) VALUES (5, N'Sân 5', 0)
INSERT [dbo].[San] ([MaSan], [TenSan], [TrangThai]) VALUES (6, N'Sân 6', 0)
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'1NT1      ', N'Ngày thường sáng', 150000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'1NT2      ', N'Ngày thường chiều', 180000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'2CT1      ', N'Cuối tuần sáng', 170000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'2CT2      ', N'Cuối tuần chiều', 200000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3BM       ', N'Bánh mì', 15000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3BN       ', N'Bánh ngọt', 10000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3HT       ', N'Hủ tiếu', 25000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3KL       ', N'Khăn lạnh', 4000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3MG       ', N'Mì gói', 6000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3NN       ', N'Nước ngọt', 15000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3NS       ', N'Nước suối', 10000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'3TD       ', N'Thùng trà đá', 15000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'4TG       ', N'Thuê giày', 70000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'4TQA      ', N'Thuê quần áo', 50000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'5BK       ', N'Băng keo cá nhân', 5000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'5BYT      ', N'Băng y tế', 8000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonGia]) VALUES (N'5C        ', N'Cồn sát khuẩn', 10000)
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [fk_MaHD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [fk_MaHD]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [fk_MaSP] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [fk_MaSP]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_MaKH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [fk_MaSan] FOREIGN KEY([MaSan])
REFERENCES [dbo].[San] ([MaSan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [fk_MaSan]
GO
