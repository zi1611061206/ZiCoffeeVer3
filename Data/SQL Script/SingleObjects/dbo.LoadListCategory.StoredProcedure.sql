USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListCategory]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LoadListCategory]    Script Date: 6/17/2019 2:17:19 PM ******/
CREATE proc [dbo].[LoadListCategory]
as
begin
	select MADANHMUC as [Mã danh mục], TENDANHMUC as [Tên danh mục] from dbo.DANHMUC
end
GO
