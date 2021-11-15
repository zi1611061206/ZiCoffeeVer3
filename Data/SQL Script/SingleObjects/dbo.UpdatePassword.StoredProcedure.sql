USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 6/17/2019 2:20:24 PM ******/
CREATE proc [dbo].[UpdatePassword]
@tendangnhap varchar(50),
@matkhau nvarchar(1000),
@matkhaumoi nvarchar(1000)
as
begin
	declare @pw_is_right int=0

	select @pw_is_right=count(*) from dbo.TAIKHOAN where tendangnhap=@tendangnhap and matkhau= @matkhau

	if(@pw_is_right>=1)
	begin
		update dbo.TAIKHOAN set matkhau = @matkhaumoi  where tendangnhap= @tendangnhap
	end
end
GO
