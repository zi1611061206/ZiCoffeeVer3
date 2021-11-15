USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchPosition]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchPosition]    Script Date: 6/17/2019 2:19:19 PM ******/
CREATE proc [dbo].[SearchPosition]
@tenchucvu nvarchar(50)
as 
begin
	select  MACHUCVU as [Mã], TENCHUCVU as [Chức vụ]
	from dbo.CHUCVU 
	where dbo.fuConvertToUnsign1(TENCHUCVU) like N'%'+dbo.fuConvertToUnsign1( @tenchucvu )+'%'
end
GO
