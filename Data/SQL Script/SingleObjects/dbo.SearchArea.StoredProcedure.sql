USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchArea]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchArea]
@tenkhuvuc nvarchar(30)
as
begin
	select makhuvuc as [Mã khu vực], tenkhuvuc as [Tên khu vực] 
	from dbo.KhuVuc 
	where dbo.fuConvertToUnsign1(TenKhuVuc) like N'%'+dbo.fuConvertToUnsign1( @tenkhuvuc )+'%'
end
GO
