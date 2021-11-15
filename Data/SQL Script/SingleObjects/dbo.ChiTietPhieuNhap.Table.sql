USE [QLCF]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/5/2020 3:57:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieu] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (4, 1, 9, 100000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (4, 3, 30, 100000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (4, 4, 18, 100000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (4, 6, 12, 100000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (5, 7, 18, 80000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (5, 9, 12, 80000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (5, 10, 3, 80000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (5, 11, 12, 80000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (5, 13, 15, 80000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (5, 14, 6, 80000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (6, 5, 12, 30000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (6, 16, 6, 340000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (6, 17, 12, 33000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (6, 20, 12, 30000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (6, 21, 12, 30000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (6, 22, 6, 340000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (7, 31, 3, 200000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (7, 34, 30, 20000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (7, 36, 3, 1000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (7, 38, 12, 30000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (7, 39, 12, 20000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (10, 8, 1, 20000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (10, 27, 1, 20000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieu], [MaNguyenLieu], [SoLuongNhap], [DonGiaNhap]) VALUES (11, 8, 2, 200000)
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [SoLuongNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((0)) FOR [DonGiaNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
GO
/****** Object:  Trigger [dbo].[AutoUpdateMaterialAmount]    Script Date: 11/5/2020 3:57:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------
create trigger [dbo].[AutoUpdateMaterialAmount] 
on [dbo].[ChiTietPhieuNhap] for insert, update
as
begin
	declare @maNguyenLieu int
	declare @soLuongNhap int
	select @maNguyenLieu = MaNguyenLieu, @soLuongNhap = SoLuongNhap from inserted

	declare @soLuongTon int
	select @soLuongTon = SoLuongTon from dbo.NguyenLieu where MaNguyenLieu = @maNguyenLieu

	set @soLuongTon+=@soLuongNhap;

	update dbo.NguyenLieu set SoLuongTon = @soLuongTon where MaNguyenLieu=@maNguyenLieu
end
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [AutoUpdateMaterialAmount]
GO
