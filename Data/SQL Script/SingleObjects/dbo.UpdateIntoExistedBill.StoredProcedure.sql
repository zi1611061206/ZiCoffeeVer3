USE [QLCF]
GO
/****** Object:  StoredProcedure [dbo].[UpdateIntoExistedBill]    Script Date: 11/5/2020 3:57:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateIntoExistedBill]
@mahoadon int,
@madouong int,
@soluong int
as
begin
	declare @existed int 
	declare @countexisted int = 1
	--kiem tra do uong da ton tai trong hoa don do chua?
	select @existed = mahoadon, @countexisted = soluong  
	from dbo.chitiethoadon 
	where mahoadon=@mahoadon and MaDichVu=@madouong
	--neu da co thi cap nhat lai soluong
	if(@existed>0)
	begin
		declare @newcount int = @countexisted + @soluong
		if(@newcount>0) --neu so luong ban dau + so luong them vao ma van con duong thi cap nhat lai soluong
		begin
			update dbo.chitiethoadon 
			set soluong = @countexisted + @soluong
			where (MaDichVu=@madouong and mahoadon=@mahoadon)
		end
		else --nguoc lai, xoa dong do uong da co khoi cthd
		begin
			delete dbo.chitiethoadon
			where (mahoadon=@mahoadon and MaDichVu=@madouong)
		end
	end
	--nguoc lai, insert do uong vao nhu 1 do uong moi
	else
	begin
		insert into dbo.chitiethoadon (mahoadon,MaDichVu,soluong) values ( @mahoadon ,  @madouong , @soluong)
	end
end
GO
