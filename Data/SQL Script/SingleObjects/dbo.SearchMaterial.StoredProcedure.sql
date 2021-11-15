USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchMaterial]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchMaterial]    Script Date: 6/17/2019 2:19:00 PM ******/
CREATE proc [dbo].[SearchMaterial]
@tennguyenlieu nvarchar(30)
as
begin
	select MANGUYENLIEU as [Mã nguyên liệu], TENNGUYENLIEU as [Tên nguyên liệu], DonViTinh as [Đơn vị], SoLuongTon as [Số lượng]
	from dbo.NGUYENLIEU
	where dbo.fuConvertToUnsign1(TENNGUYENLIEU) like N'%'+dbo.fuConvertToUnsign1( @tennguyenlieu )+'%'
end
GO
