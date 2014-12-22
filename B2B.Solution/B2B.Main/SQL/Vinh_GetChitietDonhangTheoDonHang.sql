use QLBH_08_2014
go
create proc Vinh_GetChitietDonhangTheoDonHang
	@DonhangId uniqueidentifier
as
select cd.[ChitietDonhangId]
      ,cd.[DonhangId]
      ,cd.[HanghoaId]
      ,cd.[TenHanghoa]
      ,cd.[Giaban]
      ,cd.[VAT]
      ,cd.[Soluong]
      ,cd.[Tiengiam]
      ,cd.[PhantramGiam]
      ,cd.[Thanhtien]
      ,cd.[GhichuTrahang]
      ,cd.[SoluongGiao]
      ,cd.[SoluongConlai]
      ,cd.[NgayCapnhat]
      ,cd.[Step]
      ,cd.[Version]
from ChitietDonhang cd
where cd.DonhangId = @DonhangId