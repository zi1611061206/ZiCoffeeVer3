USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[GetRevenueRecordNum]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetRevenueRecordNum]    Script Date: 6/17/2019 2:16:51 PM ******/
CREATE proc [dbo].[GetRevenueRecordNum]
@thoigiandau datetime,
@thoigiancuoi datetime
as
begin
	select count(*)	
	from dbo.HOADON as h
	where h.NgayLap >= @thoigiandau and h.NgayLap <= @thoigiancuoi and h.TrangThaiThanhToan = 1
end
GO
