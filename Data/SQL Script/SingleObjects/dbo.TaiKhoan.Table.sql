USE [QLCF]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/5/2020 3:57:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MaNhanVien], [MatKhau], [NgayLap]) VALUES (N'aye', 11, N'1', CAST(N'2020-02-29T02:14:20.623' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MaNhanVien], [MatKhau], [NgayLap]) VALUES (N'iz', 1, N'1', CAST(N'2020-02-29T02:14:20.623' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MaNhanVien], [MatKhau], [NgayLap]) VALUES (N'linh', 12, N'1', CAST(N'2020-02-29T02:14:20.623' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MaNhanVien], [MatKhau], [NgayLap]) VALUES (N'thu201', 8, N'1', CAST(N'2020-02-29T02:14:20.623' AS DateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MaNhanVien], [MatKhau], [NgayLap]) VALUES (N'zi', 1, N'1', CAST(N'2020-02-29T02:14:20.623' AS DateTime))
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__55F68FC0FA236406]    Script Date: 11/5/2020 3:57:54 AM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((1)) FOR [MatKhau]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT (getdate()) FOR [NgayLap]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
