USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListPosition]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LoadListPosition]    Script Date: 6/17/2019 2:18:13 PM ******/
CREATE proc [dbo].[LoadListPosition]
as 
begin
	select MACHUCVU as [Mã], TENCHUCVU as [Chức vụ]
	from dbo.CHUCVU
end
GO
