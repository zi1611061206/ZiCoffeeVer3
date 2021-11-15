USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[LoadListSupplier]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[LoadListSupplier]    Script Date: 6/17/2019 2:18:23 PM ******/
CREATE proc [dbo].[LoadListSupplier]
as 
begin
	select MANHACUNGCAP as [Mã], TENNHACUNGCAP as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SODIENTHOAI as [SĐT], EMAIL as [Email]
	from dbo.NHACUNGCAP
end
GO
