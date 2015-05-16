use QLBH_08_2014
go
alter proc Khuyen_GetCongnoXuat
as
begin
	select cn.[CongnoXuatId]
      ,cn.[KhachhangId]
      ,cn.[Dienthoai]
      ,cn.[Diachi]
      ,cn.[NgayGiaodich]
      ,cn.[SoduTruocGiaodich]
      ,cn.[SotienGiaodich]
      ,cn.[Tongno]
      ,cn.[NgayhenTra]
      ,cn.[NhanvienId]
      ,cn.[Ghichu]
      ,cn.[Step]
      ,cn.[Version] 
	  ,A.HotenKhachhang as TenKhachhang
	  ,nv.HovatenNhanvien as TenNhanvien
	from (select k.HotenKhachhang, (select top 1 c.[CongnoXuatId]
									from CongnoXuat c 
									where c.KhachhangId = k.KhachhangId 
									order by c.NgayGiaodich desc) as CNXId
	from Khachhang k) as A left join CongnoXuat cn on A.CNXId = cn.CongnoXuatId left join Nhanvien nv on cn.NhanvienId = nv.NhanvienId
end