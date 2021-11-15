USE [master]
GO
/****** Object:  Database [QLCF]    Script Date: 11/5/2020 3:55:20 AM ******/
CREATE DATABASE [QLCF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QLCF.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLCF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QLCF_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLCF] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCF] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCF] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLCF] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCF] SET  MULTI_USER 
GO
ALTER DATABASE [QLCF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLCF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLCF] SET QUERY_STORE = OFF
GO
USE [QLCF]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
	BEGIN 
		IF @strInput IS NULL 
			RETURN @strInput IF @strInput = '' 
			RETURN @strInput 
			DECLARE @RT NVARCHAR(4000) 
			DECLARE @SIGN_CHARS NCHAR(136) 
			DECLARE @UNSIGN_CHARS NCHAR (136) 
			SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
			SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
			DECLARE @COUNTER int 
			DECLARE @COUNTER1 int 
			SET @COUNTER = 1 
			WHILE (@COUNTER <=LEN(@strInput)) 
			BEGIN 
				SET @COUNTER1 = 1 
				WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
				BEGIN 
					IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
					BEGIN 
						IF @COUNTER=1 
							SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
						ELSE 
							SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
							BREAK 
					END 
					SET @COUNTER1 = @COUNTER1 +1 
				END 
				SET @COUNTER = @COUNTER +1 
			END 
			SET @strInput = replace(@strInput,' ','-') 
			RETURN @strInput 
	END
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[MaBan] [int] IDENTITY(1,1) NOT NULL,
	[MaKhuVuc] [int] NOT NULL,
	[TenBan] [nvarchar](30) NOT NULL,
	[TrangThaiSuDung] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaDichVu] [int] NOT NULL,
	[MaHoaDon] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[ThanhTien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieu] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuongTrinhGiamGia]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhGiamGia](
	[MaChuongTrinh] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](200) NOT NULL,
	[GiaTri] [float] NULL,
	[NgayLap] [datetime] NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[DieuKienToiThieu] [float] NULL,
	[MaLoai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuongTrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongThucPhaChe]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongThucPhaChe](
	[MaDichVu] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuongPha] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[MaDanhMuc] [int] NOT NULL,
	[TenDichVu] [nvarchar](30) NOT NULL,
	[HinhAnh] [image] NULL,
	[DonGia] [float] NOT NULL,
	[TinhTrangSuDung] [bit] NULL,
	[Mota] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[TrangThaiThanhToan] [bit] NULL,
	[ThucThu] [float] NULL,
	[VAT] [float] NULL,
	[MaPhieuGiamGia] [varchar](10) NULL,
	[MaChuongTrinhKhuyenMai] [int] NULL,
	[ThanhTien] [float] NULL,
	[GiaTriSauThue] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKhuVuc] [int] IDENTITY(1,1) NOT NULL,
	[TenKhuVuc] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiChuongTrinh]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiChuongTrinh](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](20) NULL,
 CONSTRAINT [PK_LoaiChuongTrinh] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNguyenLieu] [int] IDENTITY(1,1) NOT NULL,
	[TenNguyenLieu] [nvarchar](30) NOT NULL,
	[SoLuongTon] [int] NULL,
	[DonViTinh] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SoDienThoai] [varchar](11) NOT NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[SoDienThoai] [varchar](11) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[NgaySinh] [datetime] NULL,
	[ChungMinhNhanDan] [varchar](10) NOT NULL,
	[AnhDaiDien] [image] NULL,
	[MaChucVu] [int] NULL,
	[Ho] [nvarchar](10) NULL,
	[TenDem] [nvarchar](10) NULL,
	[Ten] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ChungMinhNhanDan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiamGia]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiamGia](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaChuongTrinh] [int] NOT NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGoiBan]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGoiBan](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaBan] [int] NOT NULL,
	[MaHoaDon] [int] NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaNhaCungCap] [int] NOT NULL,
	[Ngay] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[NgayLap] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ban] ADD  DEFAULT ((0)) FOR [TrangThaiSuDung]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [SoLuongNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [DonGiaNhap]
GO
ALTER TABLE [dbo].[ChuongTrinhGiamGia] ADD  DEFAULT ((0)) FOR [GiaTri]
GO
ALTER TABLE [dbo].[ChuongTrinhGiamGia] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[ChuongTrinhGiamGia] ADD  DEFAULT (getdate()) FOR [NgayBatDau]
GO
ALTER TABLE [dbo].[ChuongTrinhGiamGia] ADD  DEFAULT (dateadd(day,(30),getdate())) FOR [NgayKetThuc]
GO
ALTER TABLE [dbo].[ChuongTrinhGiamGia] ADD  DEFAULT ((0)) FOR [DieuKienToiThieu]
GO
ALTER TABLE [dbo].[CongThucPhaChe] ADD  DEFAULT ((0)) FOR [SoLuongPha]
GO
ALTER TABLE [dbo].[DichVu] ADD  DEFAULT (NULL) FOR [HinhAnh]
GO
ALTER TABLE [dbo].[DichVu] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[DichVu] ADD  DEFAULT ((1)) FOR [TinhTrangSuDung]
GO
ALTER TABLE [dbo].[DichVu] ADD  DEFAULT (N'Không có mô tả') FOR [Mota]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TrangThaiThanhToan]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [ThucThu]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [VAT]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [GiaTriSauThue]
GO
ALTER TABLE [dbo].[NguyenLieu] ADD  DEFAULT ((0)) FOR [SoLuongTon]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT (NULL) FOR [Email]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [GioiTinh]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_NgaySinh]  DEFAULT (getdate()) FOR [NgaySinh]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (NULL) FOR [AnhDaiDien]
GO
ALTER TABLE [dbo].[PhieuGiamGia] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [Ngay]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((1)) FOR [MatKhau]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
ALTER TABLE [dbo].[ChuongTrinhGiamGia]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiChuongTrinh] ([MaLoai])
GO
ALTER TABLE [dbo].[CongThucPhaChe]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[CongThucPhaChe]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaChuongTrinhKhuyenMai])
REFERENCES [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaPhieuGiamGia])
REFERENCES [dbo].[PhieuGiamGia] ([MaPhieu])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[PhieuGiamGia]  WITH CHECK ADD FOREIGN KEY([MaChuongTrinh])
REFERENCES [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 6/17/2019 2:10:35 PM ******/
CREATE proc [dbo].[CheckLogin]
@username varchar(50),@password nvarchar(1000)
as 
begin
	select * from dbo.TaiKhoan where TenDangNhap = @username and MatKhau = @password
end
GO
/****** Object:  StoredProcedure [dbo].[GetBillByTableID]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetBillByTableID]    Script Date: 6/17/2019 2:12:58 PM ******/
CREATE proc [dbo].[GetBillByTableID]
@maban int
as
begin
	select d.TenDichVu, c.SoLuong, d.DonGia, c.ThanhTien 
	from ChiTietHoaDon as c, HoaDon as h, DichVu as d, PhieuGoiBan as p
	where c.MaHoaDon=h.MaHoaDon and h.MaHoaDon=p.MaHoaDon and c.MaDichVu=d.MaDichVu and p.MaBan=@maban and h.TrangThaiThanhToan = 0
end
GO
/****** Object:  StoredProcedure [dbo].[GetDisplayRecord]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDisplayRecord]
@thoigiandau datetime, @thoigiancuoi datetime, @pagenumber int, @max_number_rows_ofpage int
as
begin
	declare @number_rows_select int = @max_number_rows_ofpage*@pagenumber
	declare @number_rows_except int = @max_number_rows_ofpage*(@pagenumber-1)
	
	;with revenue as (select *
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1)
	
	select count(*) from (select top (@number_rows_select) * from revenue except select top (@number_rows_except) * from revenue) as #temp
end
GO
/****** Object:  StoredProcedure [dbo].[GetRevenue]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetRevenue]
@thoigiandau datetime, @thoigiancuoi datetime, @pagenumber int, @max_number_rows_ofpage int
as
begin
	declare @number_rows_select int = @max_number_rows_ofpage*@pagenumber
	declare @number_rows_except int = @max_number_rows_ofpage*(@pagenumber-1)
	
	;with revenue as (select h.MAHOADON as [Mã hóa đơn], h.NgayLap as [Thời gian lập], h.ThanhTien as [Thành tiền], h.VAT as [Thuế VAT (%)], h.GiaTriSauThue as [Sau Thuế], h.MaPhieuGiamGia as [Mã phiếu giảm giá], h.MaChuongTrinhKhuyenMai as [Mã chương trình khuyến mãi], h.ThucThu as [Thực thu]
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1)
	 
	select top (@number_rows_select) * from revenue except select top (@number_rows_except) * from revenue
end
GO
/****** Object:  StoredProcedure [dbo].[GetRevenueForReport]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetRevenueForReport]
@thoigiandau datetime, @thoigiancuoi datetime
as
begin
	select h.MAHOADON, h.NgayLap, h.ThanhTien, h.VAT, h.GiaTriSauThue, h.MaPhieuGiamGia, h.MaChuongTrinhKhuyenMai, h.ThucThu
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1
end
GO
/****** Object:  StoredProcedure [dbo].[GetRevenueRecordNum]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetRevenueRecordNum]    Script Date: 6/17/2019 2:16:51 PM ******/
CREATE proc [dbo].[GetRevenueRecordNum]
@thoigiandau datetime,
@thoigiancuoi datetime
as
begin
	select count(*)	
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1
end
GO
/****** Object:  StoredProcedure [dbo].[GetTableList]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetTableList]    Script Date: 6/17/2019 2:17:05 PM ******/
CREATE proc [dbo].[GetTableList]
as 
begin
	select * from dbo.ban
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListAccount]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListAccount]
as
begin
	select tendangnhap as [Tên đăng nhập], NgayLap as [Ngày tạo], MaNhanVien as [Mã nhân viên] 
	from dbo.TaiKhoan
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListAccountByEmployees]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListAccountByEmployees]
@manhanvien int
as
begin
	select tendangnhap as [Tên đăng nhập], NgayLap as [Ngày tạo], MaNhanVien as [Mã nhân viên] 
	from dbo.TaiKhoan
	where MaNhanVien = @manhanvien
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListArea]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListArea]
as
begin
	select makhuvuc as [Mã khu vực], tenkhuvuc as [Tên khu vực] from dbo.KhuVuc
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListCategory]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LoadListCategory]    Script Date: 6/17/2019 2:17:19 PM ******/
CREATE proc [dbo].[LoadListCategory]
as
begin
	select MADANHMUC as [Mã danh mục], TENDANHMUC as [Tên danh mục] from dbo.DANHMUC
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListEmployees]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadListEmployees]
as 
begin
	select n.MANHANVIEN as [Mã] , n.HO as [Họ], n.TenDem as [Tên đệm], n.Ten as [Tên], n.NgaySinh as [Ngày sinh], n.GIOITINH as [Giới tính], n.CHUNGMINHNHANDAN as [CMND], n.DIACHI as [Địa chỉ], n.SODIENTHOAI as [SĐT], c.TenChucVu as [Tên chức vụ] , n.ANHDAIDIEN as [Ảnh] 
	from dbo.NHANVIEN as n, ChucVu as c
	where n.MaChucVu = c.MaChucVu
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListEmployeesByPosition]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadListEmployeesByPosition]
@machucvu int
as 
begin
	select n.MANHANVIEN as [Mã] , n.HO as [Họ], n.TenDem as [Tên đệm], n.Ten as [Tên], n.NgaySinh as [Ngày sinh], n.GIOITINH as [Giới tính], n.CHUNGMINHNHANDAN as [CMND], n.DIACHI as [Địa chỉ], n.SODIENTHOAI as [SĐT], c.TenChucVu as [Tên chức vụ] , n.ANHDAIDIEN as [Ảnh] 
	from dbo.NHANVIEN as n, ChucVu as c
	where n.MaChucVu = c.MaChucVu and c.MaChucVu = @machucvu
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListMaterial]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadListMaterial]
as
begin
	select MANGUYENLIEU as [Mã nguyên liệu], TENNGUYENLIEU as [Tên nguyên liệu], DonViTinh as [Đơn vị], SoLuongTon as [Số lượng]
	from dbo.NGUYENLIEU
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListMenu]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadListMenu]
as 
begin
	select  [Mã] = t.MaDichVu, [Tên đồ uống]=t.TenDichVu, [Tên danh mục]=d.TENDANHMUC, [Giá bán]=t.DonGia, [Mô tả]=t.Mota, [Tình trạng]=t.TinhTrangSuDung, [Hình ảnh]=t.HINHANH 
	from dbo.DichVu as t, dbo.DANHMUC as d 
	where t.MADANHMUC=d.MADANHMUC
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListMenuByCategory]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListMenuByCategory]
@madanhmuc int
as 
begin
	select  [Mã] = t.MaDichVu, [Tên đồ uống]=t.TenDichVu, [Tên danh mục]=d.TENDANHMUC, [Giá bán]=t.DonGia, [Mô tả]=t.Mota, [Tình trạng]=t.TinhTrangSuDung, [Hình ảnh]=t.HINHANH 
	from dbo.DichVu as t, dbo.DANHMUC as d 
	where t.MADANHMUC=d.MADANHMUC and t.MaDanhMuc = @madanhmuc
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListPosition]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LoadListPosition]    Script Date: 6/17/2019 2:18:13 PM ******/
CREATE proc [dbo].[LoadListPosition]
as 
begin
	select MACHUCVU as [Mã], TENCHUCVU as [Chức vụ]
	from dbo.CHUCVU
end
GO
/****** Object:  StoredProcedure [dbo].[LoadListSupplier]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LoadListSupplier]    Script Date: 6/17/2019 2:18:23 PM ******/
CREATE proc [dbo].[LoadListSupplier]
as 
begin
	select MANHACUNGCAP as [Mã], TENNHACUNGCAP as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SODIENTHOAI as [SĐT], EMAIL as [Email]
	from dbo.NHACUNGCAP
end
GO
/****** Object:  StoredProcedure [dbo].[SearchAccount]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchAccount]
@tendangnhap varchar(50)
as
begin
	select tendangnhap as [Tên đăng nhập], NgayLap as [Ngày tạo], MaNhanVien as [Mã nhân viên] 
	from dbo.TaiKhoan
	where dbo.fuConvertToUnsign1(TenDangNhap) like  N'%'+dbo.fuConvertToUnsign1( @tendangnhap )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchArea]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchArea]
@tenkhuvuc nvarchar(30)
as
begin
	select makhuvuc as [Mã khu vực], tenkhuvuc as [Tên khu vực] 
	from dbo.KhuVuc 
	where dbo.fuConvertToUnsign1(TenKhuVuc) like N'%'+dbo.fuConvertToUnsign1( @tenkhuvuc )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchCategory]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchCategory]    Script Date: 6/17/2019 2:18:36 PM ******/
CREATE proc [dbo].[SearchCategory]
@tendanhmuc nvarchar(30)
as
begin
	select MADANHMUC as [Mã danh mục], TENDANHMUC as [Tên danh mục] 
	from dbo.DANHMUC 
	where dbo.fuConvertToUnsign1(TENDANHMUC) like N'%'+dbo.fuConvertToUnsign1( @tendanhmuc )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchEmployees]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchEmployees]
@ten nvarchar(10)
as 
begin
	select n.MANHANVIEN as [Mã] , n.HO as [Họ], n.TenDem as [Tên đệm], n.Ten as [Tên], n.NgaySinh as [Ngày sinh], n.GIOITINH as [Giới tính], n.CHUNGMINHNHANDAN as [CMND], n.DIACHI as [Địa chỉ], n.SODIENTHOAI as [SĐT], c.TenChucVu as [Tên chức vụ] , n.ANHDAIDIEN as [Ảnh] 
	from dbo.NHANVIEN as n, ChucVu as c
	where n.MaChucVu = c.MaChucVu 
	and (dbo.fuConvertToUnsign1(Ho) like  N'%'+dbo.fuConvertToUnsign1( @ten )+'%' 
	or dbo.fuConvertToUnsign1(TenDem) like  N'%'+dbo.fuConvertToUnsign1( @ten )+'%' 
	or dbo.fuConvertToUnsign1(Ten) like  N'%'+dbo.fuConvertToUnsign1( @ten )+'%')
end
GO
/****** Object:  StoredProcedure [dbo].[SearchMaterial]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchMaterial]    Script Date: 6/17/2019 2:19:00 PM ******/
CREATE proc [dbo].[SearchMaterial]
@tennguyenlieu nvarchar(30)
as
begin
	select MANGUYENLIEU as [Mã nguyên liệu], TENNGUYENLIEU as [Tên nguyên liệu], DonViTinh as [Đơn vị], SoLuongTon as [Số lượng]
	from dbo.NGUYENLIEU
	where dbo.fuConvertToUnsign1(TENNGUYENLIEU) like N'%'+dbo.fuConvertToUnsign1( @tennguyenlieu )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchMenu]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchMenu]
@tendouong nvarchar(30)
as 
begin
	select  [Mã] = t.MaDichVu, [Tên đồ uống]=t.TenDichVu, [Tên danh mục]=d.TENDANHMUC, [Giá bán]=t.DonGia, [Mô tả]=t.Mota, [Tình trạng]=t.TinhTrangSuDung, [Hình ảnh]=t.HINHANH 
	from dbo.DichVu as t, dbo.DANHMUC as d 
	where t.MADANHMUC=d.MADANHMUC and dbo.fuConvertToUnsign1(TenDichVu) like N'%'+dbo.fuConvertToUnsign1( @tendouong )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchMenuName]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchMenuName]
@tendouong nvarchar(30)
as 
begin
	select  *
	from dbo.DichVu as t
	where dbo.fuConvertToUnsign1(TenDichVu) like N'%'+dbo.fuConvertToUnsign1( @tendouong )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchPosition]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchPosition]    Script Date: 6/17/2019 2:19:19 PM ******/
CREATE proc [dbo].[SearchPosition]
@tenchucvu nvarchar(50)
as 
begin
	select  MACHUCVU as [Mã], TENCHUCVU as [Chức vụ]
	from dbo.CHUCVU 
	where dbo.fuConvertToUnsign1(TENCHUCVU) like N'%'+dbo.fuConvertToUnsign1( @tenchucvu )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchSupplier]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchSupplier]    Script Date: 6/17/2019 2:19:31 PM ******/
CREATE proc [dbo].[SearchSupplier]
@tennhacungcap nvarchar(50)
as
begin
	select MANHACUNGCAP as [Mã], TENNHACUNGCAP as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SODIENTHOAI as [SĐT], EMAIL as [Email]
	from dbo.NHACUNGCAP
	where dbo.fuConvertToUnsign1(TENNHACUNGCAP) like N'%'+dbo.fuConvertToUnsign1( @tennhacungcap )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchTable]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchTable]
@tenban nvarchar(30)
as 
begin
	select  *
	from dbo.BAN 
	where dbo.fuConvertToUnsign1(TENBAN) like N'%'+dbo.fuConvertToUnsign1( @tenban )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SearchTableName]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SearchTableName]
@tenban nvarchar(30)
as 
begin
	select  *
	from dbo.BAN 
	where dbo.fuConvertToUnsign1(TENBAN) like N'%'+dbo.fuConvertToUnsign1( @tenban )+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateIntoExistedBill]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateIntoExistedBill]
@mahoadon int,
@madouong int,
@soluong int
as
begin
	declare @existed int 
	declare @countexisted int = 1
	--kiem tra do uong da ton tai trong hoa don do chua?
	select @existed = mahoadon, @countexisted = soluong  
	from dbo.chitiethoadon 
	where mahoadon=@mahoadon and MaDichVu=@madouong
	--neu da co thi cap nhat lai soluong
	if(@existed>0)
	begin
		declare @newcount int = @countexisted + @soluong
		if(@newcount>0) --neu so luong ban dau + so luong them vao ma van con duong thi cap nhat lai soluong
		begin
			update dbo.chitiethoadon 
			set soluong = @countexisted + @soluong
			where (MaDichVu=@madouong and mahoadon=@mahoadon)
		end
		else --nguoc lai, xoa dong do uong da co khoi cthd
		begin
			delete dbo.chitiethoadon
			where (mahoadon=@mahoadon and MaDichVu=@madouong)
		end
	end
	--nguoc lai, insert do uong vao nhu 1 do uong moi
	else
	begin
		insert into dbo.chitiethoadon (mahoadon,MaDichVu,soluong) values ( @mahoadon ,  @madouong , @soluong)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 6/17/2019 2:20:24 PM ******/
CREATE proc [dbo].[UpdatePassword]
@tendangnhap varchar(50),
@matkhau nvarchar(1000),
@matkhaumoi nvarchar(1000)
as
begin
	declare @pw_is_right int=0

	select @pw_is_right=count(*) from dbo.TAIKHOAN where tendangnhap=@tendangnhap and matkhau= @matkhau

	if(@pw_is_right>=1)
	begin
		update dbo.TAIKHOAN set matkhau = @matkhaumoi  where tendangnhap= @tendangnhap
	end
end
GO
/****** Object:  Trigger [dbo].[UpdatePriceFollowMenu]    Script Date: 11/5/2020 3:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------
create trigger [dbo].[UpdatePriceFollowMenu]
on [dbo].[ChiTietHoaDon] for insert, update
as 
begin
	declare @maDoUong int
	declare @maHoaDon int
	declare @giaBan float
	declare @soLuong int

	select @maDoUong=MaDichVu, @maHoaDon=MaHoaDon, @soLuong=cast(SoLuong as float) from inserted
	select @giaBan=DonGia from dbo.DichVu where MaDichVu=@maDoUong

	declare @thanhTien float
	set @thanhTien=@giaBan*@soLuong
	update dbo.ChiTietHoaDon set ThanhTien=@thanhTien where MaDichVu=@maDoUong and MaHoaDon=@maHoaDon
end
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [UpdatePriceFollowMenu]
GO
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenCancelOrder]    Script Date: 11/5/2020 3:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------
create trigger [dbo].[UpdateTableStatusWhenCancelOrder] --DeleteBillInfo
on [dbo].[ChiTietHoaDon] for delete
as
begin
	declare @maHoaDon int
	select @maHoaDon = MaHoaDon from deleted

	declare @maBan int
	select @maBan = MaBan from dbo.PhieuGoiBan where MaHoaDon = @maHoaDon

	declare @dem int =0
	select @dem = count(*) from dbo.ChiTietHoaDon as c, dbo.HoaDon as h where c.MaHoaDon=h.MaHoaDon and c.MaHoaDon=@maHoaDon and h.TrangThaiThanhToan = 0

	if(@dem = 0)
		update dbo.Ban set TrangThaiSuDung = 0 where MaBan = @maBan
end
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [UpdateTableStatusWhenCancelOrder]
GO
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenOrder]    Script Date: 11/5/2020 3:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--trigger
create trigger [dbo].[UpdateTableStatusWhenOrder] --UpdateBillInfo
on [dbo].[ChiTietHoaDon] for insert, update
as 
begin
	declare @maHoaDon int
	declare @maBan int

	select @maHoaDon=MaHoaDon from inserted
	select @maBan=MaBan from dbo.PhieuGoiBan as p, dbo.HoaDon as h where h.MaHoaDon=p.MaHoaDon and p.MaHoaDon=@maHoaDon and TrangThaiThanhToan = 0

	update dbo.Ban set TrangThaiSuDung = 1 where MaBan=@maBan
end
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [UpdateTableStatusWhenOrder]
GO
/****** Object:  Trigger [dbo].[AutoUpdateMaterialAmount]    Script Date: 11/5/2020 3:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------
create trigger [dbo].[AutoUpdateMaterialAmount] 
on [dbo].[ChiTietPhieuNhap] for insert, update
as
begin
	declare @maNguyenLieu int
	declare @soLuongNhap int
	select @maNguyenLieu = MaNguyenLieu, @soLuongNhap = SoLuongNhap from inserted

	declare @soLuongTon int
	select @soLuongTon = SoLuongTon from dbo.NguyenLieu where MaNguyenLieu = @maNguyenLieu

	set @soLuongTon+=@soLuongNhap;

	update dbo.NguyenLieu set SoLuongTon = @soLuongTon where MaNguyenLieu=@maNguyenLieu
end
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [AutoUpdateMaterialAmount]
GO
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenPay]    Script Date: 11/5/2020 3:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------
create trigger [dbo].[UpdateTableStatusWhenPay] 
on [dbo].[HoaDon] for insert, update
as
begin
	declare @maHoaDon int
	select @maHoaDon = MaHoaDon from inserted

	declare @maBan int
	select @maBan = MaBan from dbo.PhieuGoiBan where MaHoaDon = @maHoaDon

	declare @dem int =0
	select @dem=COUNT(*) from HoaDon as h, PhieuGoiBan as p where h.MaHoaDon=p.MaHoaDon and MaBan=@maBan and TrangThaiThanhToan=0

	if(@dem = 0)
		update dbo.Ban set TrangThaiSuDung = 0 where MaBan = @maBan
end
GO
ALTER TABLE [dbo].[HoaDon] ENABLE TRIGGER [UpdateTableStatusWhenPay]
GO
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenMove]    Script Date: 11/5/2020 3:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------
create trigger [dbo].[UpdateTableStatusWhenMove] --UpdateBill
on [dbo].[PhieuGoiBan] for update 
as
begin
	declare @maBanCanChuyen int
	declare @maBanChuyenDen int
	declare @maPhieu int
	declare @maBan int
	declare @dem int
	
	select @maPhieu=MaPhieu from inserted
	select @maBan=MaBan from dbo.PhieuGoiBan where MaPhieu=@maPhieu

	select @maBanChuyenDen=MaBan from inserted
	select @maBanCanChuyen=MaBan from deleted
	select @dem =count(*) from dbo.HoaDon as h, dbo.PhieuGoiBan as p where h.MaHoaDon=p.MaHoaDon and MaBan=@maBan and TrangThaiThanhToan=0

	update dbo.Ban set TrangThaiSuDung=0 where MaBan=@maBanCanChuyen
	update dbo.Ban set TrangThaiSuDung=1 where MaBan=@maBanChuyenDen
	
	if(@dem=0)
		update dbo.Ban set TrangThaiSuDung=0 where MaBan=@maBan
end
GO
ALTER TABLE [dbo].[PhieuGoiBan] ENABLE TRIGGER [UpdateTableStatusWhenMove]
GO
USE [master]
GO
ALTER DATABASE [QLCF] SET  READ_WRITE 
GO
