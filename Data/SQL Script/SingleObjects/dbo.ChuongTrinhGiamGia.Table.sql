USE [QLCF]
GO
/****** Object:  Table [dbo].[ChuongTrinhGiamGia]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[ChuongTrinhGiamGia] ON 

INSERT [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh], [NoiDung], [GiaTri], [NgayLap], [NgayBatDau], [NgayKetThuc], [DieuKienToiThieu], [MaLoai]) VALUES (1, N'Giảm giá 8/3', 10, CAST(N'2020-03-01T21:40:31.813' AS DateTime), CAST(N'2020-03-01T21:40:31.813' AS DateTime), CAST(N'2020-03-31T21:40:31.813' AS DateTime), 0, 1)
INSERT [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh], [NoiDung], [GiaTri], [NgayLap], [NgayBatDau], [NgayKetThuc], [DieuKienToiThieu], [MaLoai]) VALUES (2, N'Merry Christmas', 5, CAST(N'2020-03-01T21:41:56.957' AS DateTime), CAST(N'2020-03-01T21:41:56.957' AS DateTime), CAST(N'2020-03-31T21:41:56.957' AS DateTime), 20000, 1)
INSERT [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh], [NoiDung], [GiaTri], [NgayLap], [NgayBatDau], [NgayKetThuc], [DieuKienToiThieu], [MaLoai]) VALUES (3, N'voucher giảm giá cặp đôi', 5000, CAST(N'2020-03-01T21:42:38.140' AS DateTime), CAST(N'2020-03-01T21:42:38.140' AS DateTime), CAST(N'2020-03-31T21:42:38.140' AS DateTime), 10000, 2)
INSERT [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh], [NoiDung], [GiaTri], [NgayLap], [NgayBatDau], [NgayKetThuc], [DieuKienToiThieu], [MaLoai]) VALUES (4, N'coupon 20/10', 20, CAST(N'2020-03-01T21:44:29.810' AS DateTime), CAST(N'2020-03-01T21:44:29.810' AS DateTime), CAST(N'2020-03-31T21:44:29.810' AS DateTime), 10000, 3)
SET IDENTITY_INSERT [dbo].[ChuongTrinhGiamGia] OFF
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
ALTER TABLE [dbo].[ChuongTrinhGiamGia]  WITH CHECK ADD FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiChuongTrinh] ([MaLoai])
GO
