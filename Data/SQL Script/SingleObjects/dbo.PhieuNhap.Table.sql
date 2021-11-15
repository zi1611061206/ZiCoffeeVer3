USE [QLCF]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (4, 1, CAST(N'2019-07-07T17:05:07.437' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (5, 2, CAST(N'2019-07-07T17:06:01.043' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (6, 5, CAST(N'2019-07-07T17:06:27.577' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (7, 6, CAST(N'2019-07-07T17:10:08.233' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (9, 3, CAST(N'2019-07-07T17:12:06.957' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (10, 8, CAST(N'2019-09-26T19:07:55.743' AS DateTime))
INSERT [dbo].[PhieuNhap] ([MaPhieu], [MaNhaCungCap], [Ngay]) VALUES (11, 7, CAST(N'2020-02-29T17:44:28.027' AS DateTime))
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT (getdate()) FOR [Ngay]
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
