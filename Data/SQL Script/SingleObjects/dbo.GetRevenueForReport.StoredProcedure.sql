USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[GetRevenueForReport]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetRevenueForReport]
@thoigiandau datetime, @thoigiancuoi datetime
as
begin
	select h.MAHOADON, h.NgayLap, h.ThanhTien, h.VAT, h.GiaTriSauThue, h.MaPhieuGiamGia, h.MaChuongTrinhKhuyenMai, h.ThucThu
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1
end
GO
