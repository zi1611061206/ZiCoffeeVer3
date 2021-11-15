USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListAccountByEmployees]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListAccountByEmployees]
@manhanvien int
as
begin
	select tendangnhap as [Tên đăng nhập], NgayLap as [Ngày tạo], MaNhanVien as [Mã nhân viên] 
	from dbo.TaiKhoan
	where MaNhanVien = @manhanvien
end
GO
