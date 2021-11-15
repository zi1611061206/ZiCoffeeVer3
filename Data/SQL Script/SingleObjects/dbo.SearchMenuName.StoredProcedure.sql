USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchMenuName]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchMenuName]
@tendouong nvarchar(30)
as 
begin
	select  *
	from dbo.DichVu as t
	where dbo.fuConvertToUnsign1(TenDichVu) like N'%'+dbo.fuConvertToUnsign1( @tendouong )+'%'
end
GO
