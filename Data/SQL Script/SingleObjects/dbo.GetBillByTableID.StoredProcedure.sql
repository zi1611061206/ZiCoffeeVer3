USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[GetBillByTableID]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetBillByTableID]    Script Date: 6/17/2019 2:12:58 PM ******/
CREATE proc [dbo].[GetBillByTableID]
@maban int
as
begin
	select d.TenDichVu, c.SoLuong, d.DonGia, c.ThanhTien 
	from ChiTietHoaDon as c, HoaDon as h, DichVu as d, PhieuGoiBan as p
	where c.MaHoaDon=h.MaHoaDon and h.MaHoaDon=p.MaHoaDon and c.MaDichVu=d.MaDichVu and p.MaBan=@maban and h.TrangThaiThanhToan = 0
end
GO
