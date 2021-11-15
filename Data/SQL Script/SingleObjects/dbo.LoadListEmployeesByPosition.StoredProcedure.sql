USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListEmployeesByPosition]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadListEmployeesByPosition]
@machucvu int
as 
begin
	select n.MANHANVIEN as [Mã] , n.HO as [Họ], n.TenDem as [Tên đệm], n.Ten as [Tên], n.NgaySinh as [Ngày sinh], n.GIOITINH as [Giới tính], n.CHUNGMINHNHANDAN as [CMND], n.DIACHI as [Địa chỉ], n.SODIENTHOAI as [SĐT], c.TenChucVu as [Tên chức vụ] , n.ANHDAIDIEN as [Ảnh] 
	from dbo.NHANVIEN as n, ChucVu as c
	where n.MaChucVu = c.MaChucVu and c.MaChucVu = @machucvu
end
GO
