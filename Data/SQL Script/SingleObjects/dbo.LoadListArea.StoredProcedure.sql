USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListArea]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListArea]
as
begin
	select makhuvuc as [Mã khu vực], tenkhuvuc as [Tên khu vực] from dbo.KhuVuc
end
GO
