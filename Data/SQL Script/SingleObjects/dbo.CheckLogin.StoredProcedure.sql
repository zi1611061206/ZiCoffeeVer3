USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 6/17/2019 2:10:35 PM ******/
CREATE proc [dbo].[CheckLogin]
@username varchar(50),@password nvarchar(1000)
as 
begin
	select * from dbo.TaiKhoan where TenDangNhap = @username and MatKhau = @password
end
GO
