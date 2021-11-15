USE [QLCF]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (1, 1, N'Bàn 1', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (2, 1, N'Bàn 2', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (3, 1, N'Bàn 3', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (4, 1, N'Bàn 4', 1)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (5, 1, N'Bàn 5', 1)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (6, 1, N'Bàn 6', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (7, 1, N'Bàn 7', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (8, 1, N'Bàn 8', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (9, 1, N'Bàn 9', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (10, 1, N'Bàn 10', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (11, 1, N'Bàn 11', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (12, 1, N'Bàn 12', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (13, 1, N'Bàn 13', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (14, 1, N'Bàn 14', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (15, 1, N'Bàn 15', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (16, 2, N'Bàn 1', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (17, 2, N'Bàn 2', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (18, 2, N'Bàn 3', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (19, 2, N'Bàn 4', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (20, 2, N'Bàn 5', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (21, 2, N'Bàn 6', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (22, 2, N'Bàn 7', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (23, 3, N'VIP 01', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (24, 3, N'VIP 02', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (25, 3, N'VIP 03', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (26, 3, N'VIP 04', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (27, 3, N'VIP 05', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (28, 4, N'Bàn lớn A', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (29, 4, N'Bàn lớn B', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (30, 4, N'Bàn lớn C', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (31, 4, N'Bàn lớn D', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (32, 4, N'Bàn lớn E', 0)
INSERT [dbo].[Ban] ([MaBan], [MaKhuVuc], [TenBan], [TrangThaiSuDung]) VALUES (33, 4, N'Bàn lớn Z', 0)
SET IDENTITY_INSERT [dbo].[Ban] OFF
ALTER TABLE [dbo].[Ban] ADD  DEFAULT ((0)) FOR [TrangThaiSuDung]
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
