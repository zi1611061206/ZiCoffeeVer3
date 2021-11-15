USE [QLCF]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (1, N'Trung Nguyên', N'234 Q7, TP HCM', N'0978767575', N'trungnguyen@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (2, N'MONIN MONSTER', N'2 Nguyễn Trãi Q1, TP HCM', N'0923232323', N'monstermonin@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (3, N'Syrup Torani', N'56 Hai Bà Trưng, HN', N'0967543545', N'syruptorani@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (4, N'Teisseire', N'23 Bình quới', N'0934565678', N'teisseire@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (5, N'Golden Farm', N'2 Lê Lợi, Q8, TP HCM', N'097899000', N'goldenfarm@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (6, N'DaVinci', N'Q9, TPHCM', N'0970000075', N'davinci@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (7, N'Cocacola', N'Đà lạt', N'0978888888', N'cocacola@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (8, N'Pepsi', N'Vũng Tàu', N'0976666675', N'pepsi@yahoo.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (9, N'Lavie', N'234 Q7, TP HCM', N'0987768763', N'lavieeeeee@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (10, N'Nestle', N'2 Quận Phú Nhuận, HCM', N'0978767575', N'estleestle@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (11, N'Vinamilk', N'KCN Đồng nai', N'097874565', N'Vinamilk@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (12, N'Chợ đầu mối', N'Q3, TP HCM', N'0945467575', N'')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT (NULL) FOR [Email]
GO
