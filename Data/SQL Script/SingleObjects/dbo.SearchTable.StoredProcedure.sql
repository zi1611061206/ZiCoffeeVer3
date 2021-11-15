USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchTable]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchTable]
@tenban nvarchar(30)
as 
begin
	select  *
	from dbo.BAN 
	where dbo.fuConvertToUnsign1(TENBAN) like N'%'+dbo.fuConvertToUnsign1( @tenban )+'%'
end
GO
