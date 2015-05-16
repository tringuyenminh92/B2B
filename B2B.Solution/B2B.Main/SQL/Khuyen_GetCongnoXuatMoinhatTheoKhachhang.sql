use QLBH_08_2014
go
alter proc Khuyen_GetCongnoXuatMoinhatTheoKhachhang
@KhachhangId uniqueidentifier
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
	from CongnoXuat cn 
	where cn.KhachhangId=@KhachhangId and cn.NgayGiaodich=(select Max(NgayGiaodich) from CongnoXuat where cn.KhachhangId=@KhachhangId)
end