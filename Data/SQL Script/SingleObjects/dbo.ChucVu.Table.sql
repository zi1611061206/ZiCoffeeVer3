USE [QLCF]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (1, N'Quản lý')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (2, N'Thu ngân')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (3, N'Thủ kho')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (4, N'Phục vụ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (5, N'Pha chế')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (6, N'Lao công')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (7, N'Bảo vệ')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
