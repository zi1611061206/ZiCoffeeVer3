USE [QLCF]
GO
/****** Object:  Table [dbo].[LoaiChuongTrinh]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[LoaiChuongTrinh] ON 

INSERT [dbo].[LoaiChuongTrinh] ([MaLoai], [TenLoai]) VALUES (1, N'Discount')
INSERT [dbo].[LoaiChuongTrinh] ([MaLoai], [TenLoai]) VALUES (2, N'Voucher')
INSERT [dbo].[LoaiChuongTrinh] ([MaLoai], [TenLoai]) VALUES (3, N'Coupon')
SET IDENTITY_INSERT [dbo].[LoaiChuongTrinh] OFF
