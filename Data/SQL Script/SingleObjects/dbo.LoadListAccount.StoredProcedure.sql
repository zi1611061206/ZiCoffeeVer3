USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListAccount]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListAccount]
as
begin
	select tendangnhap as [Tên đăng nhập], NgayLap as [Ngày tạo], MaNhanVien as [Mã nhân viên] 
	from dbo.TaiKhoan
end
GO
