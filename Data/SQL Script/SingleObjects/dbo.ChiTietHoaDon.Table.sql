USE [QLCF]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/5/2020 3:57:53 AM ******/
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
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (5, 164, 4, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (5, 165, 4, 100000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (5, 167, 2, 50000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (6, 166, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (22, 166, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (23, 166, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (53, 168, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaDichVu], [MaHoaDon], [SoLuong], [ThanhTien]) VALUES (54, 168, 3, 69000)
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
/****** Object:  Trigger [dbo].[UpdatePriceFollowMenu]    Script Date: 11/5/2020 3:57:54 AM ******/
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
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenCancelOrder]    Script Date: 11/5/2020 3:57:54 AM ******/
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
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenOrder]    Script Date: 11/5/2020 3:57:54 AM ******/
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
