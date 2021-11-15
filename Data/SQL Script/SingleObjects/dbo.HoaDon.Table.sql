USE [QLCF]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/5/2020 3:57:53 AM ******/
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
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TrangThaiThanhToan], [ThucThu], [VAT], [MaPhieuGiamGia], [MaChuongTrinhKhuyenMai], [ThanhTien], [GiaTriSauThue]) VALUES (164, CAST(N'2020-03-03T14:36:26.377' AS DateTime), 1, 110000, 10, NULL, NULL, 100000, 110000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TrangThaiThanhToan], [ThucThu], [VAT], [MaPhieuGiamGia], [MaChuongTrinhKhuyenMai], [ThanhTien], [GiaTriSauThue]) VALUES (165, CAST(N'2020-03-03T14:46:03.213' AS DateTime), 1, 110000, 10, NULL, NULL, 100000, 110000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TrangThaiThanhToan], [ThucThu], [VAT], [MaPhieuGiamGia], [MaChuongTrinhKhuyenMai], [ThanhTien], [GiaTriSauThue]) VALUES (166, CAST(N'2020-03-04T17:34:27.770' AS DateTime), 0, 0, 0, NULL, NULL, 0, 0)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TrangThaiThanhToan], [ThucThu], [VAT], [MaPhieuGiamGia], [MaChuongTrinhKhuyenMai], [ThanhTien], [GiaTriSauThue]) VALUES (167, CAST(N'2020-05-06T00:50:42.750' AS DateTime), 1, 52250, 10, NULL, 2, 50000, 55000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [NgayLap], [TrangThaiThanhToan], [ThucThu], [VAT], [MaPhieuGiamGia], [MaChuongTrinhKhuyenMai], [ThanhTien], [GiaTriSauThue]) VALUES (168, CAST(N'2020-07-09T19:13:07.883' AS DateTime), 0, 0, 0, NULL, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
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
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaChuongTrinhKhuyenMai])
REFERENCES [dbo].[ChuongTrinhGiamGia] ([MaChuongTrinh])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaPhieuGiamGia])
REFERENCES [dbo].[PhieuGiamGia] ([MaPhieu])
GO
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenPay]    Script Date: 11/5/2020 3:57:55 AM ******/
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
