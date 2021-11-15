USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchMenu]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchMenu]
@tendouong nvarchar(30)
as 
begin
	select  [Mã] = t.MaDichVu, [Tên đồ uống]=t.TenDichVu, [Tên danh mục]=d.TENDANHMUC, [Giá bán]=t.DonGia, [Mô tả]=t.Mota, [Tình trạng]=t.TinhTrangSuDung, [Hình ảnh]=t.HINHANH 
	from dbo.DichVu as t, dbo.DANHMUC as d 
	where t.MADANHMUC=d.MADANHMUC and dbo.fuConvertToUnsign1(TenDichVu) like N'%'+dbo.fuConvertToUnsign1( @tendouong )+'%'
end
GO
