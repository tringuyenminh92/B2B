use QLBH_08_2014
go
create proc Vinh_GetChitietPhieuxuatTheoPhieuxuat
	@PhieuxuatId uniqueidentifier
as
select ctpx.[ChitietPhieuxuatId]
      ,ctpx.[PhieuxuatId]
      ,ctpx.[HanghoaId]
      ,ctpx.[Soluong]
      ,ctpx.[Ghichu]
      ,ctpx.[Step]
      ,ctpx.[Version]
      ,ctpx.[ChitietDonhangId]
	  ,hh.TenHanghoa as TenHanghoa
from ChitietPhieuxuat ctpx left join Hanghoa hh on ctpx.HanghoaId = hh.HanghoaId
where ctpx.PhieuxuatId = @PhieuxuatId
	