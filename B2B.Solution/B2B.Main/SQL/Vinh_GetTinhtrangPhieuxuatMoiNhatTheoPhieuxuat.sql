use QLBH_08_2014
go
create proc Vinh_GetTinhtrangPhieuxuatMoiNhatTheoPhieuxuat
	@PhieuxuatId uniqueidentifier
as
select top 1 tt.[TinhtrangPhieuxuatId]
      ,tt.[PhieuxuatId]
      ,tt.[TinhtrangId]
      ,tt.[NgayCapnhat]
      ,tt.[NhanvienCapnhatId]
      ,tt.[GhichuLydo]
      ,tt.[Version]
from TinhtrangPhieuxuat tt
where tt.PhieuxuatId = @PhieuxuatId
order by tt.NgayCapnhat desc
	