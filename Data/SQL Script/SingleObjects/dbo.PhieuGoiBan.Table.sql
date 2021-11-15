USE [QLCF]
GO
/****** Object:  Table [dbo].[PhieuGoiBan]    Script Date: 11/5/2020 3:57:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGoiBan](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaBan] [int] NOT NULL,
	[MaHoaDon] [int] NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhieuGoiBan] ON 

INSERT [dbo].[PhieuGoiBan] ([MaPhieu], [MaBan], [MaHoaDon], [TenDangNhap]) VALUES (126, 3, 164, N'zi')
INSERT [dbo].[PhieuGoiBan] ([MaPhieu], [MaBan], [MaHoaDon], [TenDangNhap]) VALUES (127, 4, 165, N'zi')
INSERT [dbo].[PhieuGoiBan] ([MaPhieu], [MaBan], [MaHoaDon], [TenDangNhap]) VALUES (128, 5, 166, N'zi')
INSERT [dbo].[PhieuGoiBan] ([MaPhieu], [MaBan], [MaHoaDon], [TenDangNhap]) VALUES (129, 4, 167, N'zi')
INSERT [dbo].[PhieuGoiBan] ([MaPhieu], [MaBan], [MaHoaDon], [TenDangNhap]) VALUES (130, 4, 168, N'zi')
SET IDENTITY_INSERT [dbo].[PhieuGoiBan] OFF
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[Ban] ([MaBan])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[PhieuGoiBan]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
/****** Object:  Trigger [dbo].[UpdateTableStatusWhenMove]    Script Date: 11/5/2020 3:57:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------
create trigger [dbo].[UpdateTableStatusWhenMove] --UpdateBill
on [dbo].[PhieuGoiBan] for update 
as
begin
	declare @maBanCanChuyen int
	declare @maBanChuyenDen int
	declare @maPhieu int
	declare @maBan int
	declare @dem int
	
	select @maPhieu=MaPhieu from inserted
	select @maBan=MaBan from dbo.PhieuGoiBan where MaPhieu=@maPhieu

	select @maBanChuyenDen=MaBan from inserted
	select @maBanCanChuyen=MaBan from deleted
	select @dem =count(*) from dbo.HoaDon as h, dbo.PhieuGoiBan as p where h.MaHoaDon=p.MaHoaDon and MaBan=@maBan and TrangThaiThanhToan=0

	update dbo.Ban set TrangThaiSuDung=0 where MaBan=@maBanCanChuyen
	update dbo.Ban set TrangThaiSuDung=1 where MaBan=@maBanChuyenDen
	
	if(@dem=0)
		update dbo.Ban set TrangThaiSuDung=0 where MaBan=@maBan
end
GO
ALTER TABLE [dbo].[PhieuGoiBan] ENABLE TRIGGER [UpdateTableStatusWhenMove]
GO
