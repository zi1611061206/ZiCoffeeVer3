USE [QLCF]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (1, N'Cafe Chồn', 18, N'Kg')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (2, N'Cafe Bột rang bơ', 0, N'Kg')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (3, N'Cafe mix trà xanh', 60, N'Kg')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (4, N'Cafe Vối nguyên chất', 36, N'Kg')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (5, N'Milo bột', 24, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (6, N'Cacao corona bột', 24, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (7, N'Siro Strawberry', 36, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (8, N'Siro Blueberry', 4, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (9, N'Siro Blue Sky', 24, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (10, N'Siro Rose', 6, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (11, N'Siro Vanille', 24, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (12, N'Siro Lemon', 0, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (13, N'Siro Mango', 30, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (14, N'Siro Peach', 12, N'Chai')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (15, N'Sữa đặc ông thọ', 0, N'Lon bơ')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (16, N'Sữa đặc ngôi sao', 12, N'Lon bơ')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (17, N'Sữa đặc ông thọ', 24, N'Hộp giấy')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (18, N'Sữa tươi vinamik', 0, N'Hộp giấy')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (19, N'Sữa tươi vinamik không đường', 0, N'Hộp giấy')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (20, N'Trà hương', 24, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (21, N'Trà Sen', 24, N'Gói')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (22, N'Bột trà sữa', 12, N'Hộp giấy')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (23, N'Chanh dây', 0, N'Quả')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (24, N'Saboche', 0, N'Trái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (25, N'Dưa hấu', 0, N'Trái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (26, N'Xoài', 0, N'Trái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (27, N'Táo', 2, N'Quả')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (28, N'Dưa lưới', 0, N'Trái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (29, N'Chanh', 0, N'Quả')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (30, N'Bột matcha', 0, N'Hộp')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (31, N'Máy xay sinh tố', 6, N'Chiếc')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (32, N'Máy ép', 0, N'Kg')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (33, N'Đào', 0, N'Trái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (34, N'Muỗng Lvata', 60, N'Cái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (35, N'Ly cocktail ', 0, N'Cái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (36, N'Bình nước nóng', 6, N'Chiếc')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (37, N'Cốc capuchino', 0, N'Cái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (38, N'Phin Lớn', 24, N'Cái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (39, N'Phin nhỏ', 24, N'Cái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (40, N'Đĩa trái cây lớn', 0, N'Cái')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (41, N'Gừng', 0, N'Củ')
INSERT [dbo].[NguyenLieu] ([MaNguyenLieu], [TenNguyenLieu], [SoLuongTon], [DonViTinh]) VALUES (42, N'Nước sấu', 0, N'Hũ')
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
ALTER TABLE [dbo].[NguyenLieu] ADD  DEFAULT ((0)) FOR [SoLuongTon]
GO
