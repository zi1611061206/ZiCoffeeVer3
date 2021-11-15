USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListMenuByCategory]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadListMenuByCategory]
@madanhmuc int
as 
begin
	select  [Mã] = t.MaDichVu, [Tên đồ uống]=t.TenDichVu, [Tên danh mục]=d.TENDANHMUC, [Giá bán]=t.DonGia, [Mô tả]=t.Mota, [Tình trạng]=t.TinhTrangSuDung, [Hình ảnh]=t.HINHANH 
	from dbo.DichVu as t, dbo.DANHMUC as d 
	where t.MADANHMUC=d.MADANHMUC and t.MaDanhMuc = @madanhmuc
end
GO
