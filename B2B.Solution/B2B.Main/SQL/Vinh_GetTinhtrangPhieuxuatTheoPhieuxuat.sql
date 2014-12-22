use QLBH_08_2014
go
create proc Vinh_GetTinhtrangPhieuxuatTheoPhieuxuat
	@PhieuxuatId uniqueidentifier
as
select tt.[TinhtrangPhieuxuatId]
      ,tt.[PhieuxuatId]
      ,tt.[TinhtrangId]
      ,tt.[NgayCapnhat]
      ,tt.[NhanvienCapnhatId]
      ,tt.[GhichuLydo]
      ,tt.[Version]
from TinhtrangPhieuxuat tt where tt.PhieuxuatId = @PhieuxuatId
	