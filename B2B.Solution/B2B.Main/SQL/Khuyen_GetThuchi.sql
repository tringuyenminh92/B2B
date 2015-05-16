use QLBH_08_2014
go
create proc Khuyen_GetThuchi
as
begin
	select t.[ThuchiId]
      ,t.[NhanvienId]
      ,t.[PhieunhapId]
      ,t.[PhieuxuatId]
      ,t.[Tongtien]
      ,t.[Vaoluc]
      ,t.[Ngay]
      ,t.[Thang]
      ,t.[Nam]
      ,t.[Ghichu]
      ,t.[Step]
      ,t.[Version]
      ,t.[NhannopTienId]
      ,t.[TenNhannopTien]
	  ,n.HovatenNhanvien as TenNhanvien
	from Thuchi t left join Nhanvien n on t.NhanvienId = n.NhanvienId
end