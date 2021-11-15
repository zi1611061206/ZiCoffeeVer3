USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListMaterial]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadListMaterial]
as
begin
	select MANGUYENLIEU as [Mã nguyên liệu], TENNGUYENLIEU as [Tên nguyên liệu], DonViTinh as [Đơn vị], SoLuongTon as [Số lượng]
	from dbo.NGUYENLIEU
end
GO
