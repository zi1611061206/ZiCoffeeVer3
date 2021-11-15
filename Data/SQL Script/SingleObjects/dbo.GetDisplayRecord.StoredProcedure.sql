USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[GetDisplayRecord]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDisplayRecord]
@thoigiandau datetime, @thoigiancuoi datetime, @pagenumber int, @max_number_rows_ofpage int
as
begin
	declare @number_rows_select int = @max_number_rows_ofpage*@pagenumber
	declare @number_rows_except int = @max_number_rows_ofpage*(@pagenumber-1)
	
	;with revenue as (select *
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1)
	
	select count(*) from (select top (@number_rows_select) * from revenue except select top (@number_rows_except) * from revenue) as #temp
end
GO
