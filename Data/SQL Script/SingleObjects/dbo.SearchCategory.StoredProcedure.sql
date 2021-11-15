USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchCategory]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchCategory]    Script Date: 6/17/2019 2:18:36 PM ******/
CREATE proc [dbo].[SearchCategory]
@tendanhmuc nvarchar(30)
as
begin
	select MADANHMUC as [Mã danh mục], TENDANHMUC as [Tên danh mục] 
	from dbo.DANHMUC 
	where dbo.fuConvertToUnsign1(TENDANHMUC) like N'%'+dbo.fuConvertToUnsign1( @tendanhmuc )+'%'
end
GO
