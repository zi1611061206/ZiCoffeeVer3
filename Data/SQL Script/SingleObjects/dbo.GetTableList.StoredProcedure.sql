USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[GetTableList]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[GetTableList]    Script Date: 6/17/2019 2:17:05 PM ******/
CREATE proc [dbo].[GetTableList]
as 
begin
	select * from dbo.ban
end
GO
