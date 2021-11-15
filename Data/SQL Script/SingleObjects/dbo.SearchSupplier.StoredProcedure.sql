USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[SearchSupplier]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[SearchSupplier]    Script Date: 6/17/2019 2:19:31 PM ******/
CREATE proc [dbo].[SearchSupplier]
@tennhacungcap nvarchar(50)
as
begin
	select MANHACUNGCAP as [Mã], TENNHACUNGCAP as [Tên nhà cung cấp], DIACHI as [Địa chỉ], SODIENTHOAI as [SĐT], EMAIL as [Email]
	from dbo.NHACUNGCAP
	where dbo.fuConvertToUnsign1(TENNHACUNGCAP) like N'%'+dbo.fuConvertToUnsign1( @tennhacungcap )+'%'
end
GO
