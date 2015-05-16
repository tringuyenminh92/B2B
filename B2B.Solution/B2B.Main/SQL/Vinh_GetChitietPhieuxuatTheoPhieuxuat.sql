use QLBH_08_2014
go
alter proc Vinh_GetChitietPhieuxuatTheoPhieuxuat
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
	  ,ctpx.[Thanhtien]
	  ,hh.TenHanghoa as TenHanghoa
	  ,ctdh.Giaban as Dongia
from ChitietPhieuxuat ctpx left join Hanghoa hh on ctpx.HanghoaId = hh.HanghoaId left join ChitietDonhang ctdh on ctpx.ChitietDonhangId = ctdh.ChitietDonhangId
where ctpx.PhieuxuatId = @PhieuxuatId
	