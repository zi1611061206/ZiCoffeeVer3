USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[GetRevenue]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetRevenue]
@thoigiandau datetime, @thoigiancuoi datetime, @pagenumber int, @max_number_rows_ofpage int
as
begin
	declare @number_rows_select int = @max_number_rows_ofpage*@pagenumber
	declare @number_rows_except int = @max_number_rows_ofpage*(@pagenumber-1)
	
	;with revenue as (select h.MAHOADON as [Mã hóa đơn], h.NgayLap as [Thời gian lập], h.ThanhTien as [Thành tiền], h.VAT as [Thuế VAT (%)], h.GiaTriSauThue as [Sau Thuế], h.MaPhieuGiamGia as [Mã phiếu giảm giá], h.MaChuongTrinhKhuyenMai as [Mã chương trình khuyến mãi], h.ThucThu as [Thực thu]
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1)
	 
	select top (@number_rows_select) * from revenue except select top (@number_rows_except) * from revenue
end
GO
