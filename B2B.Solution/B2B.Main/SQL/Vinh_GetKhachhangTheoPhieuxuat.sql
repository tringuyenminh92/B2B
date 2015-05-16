use QLBH_08_2014
go
alter proc [dbo].[Vinh_GetKhachhangTheoPhieuxuat]
@PhieuxuatId uniqueidentifier
as
	select dh.[DonhangId]
      ,dh.[Code]
      ,dh.[NhanvienId]
      ,dh.[Ngaylap]
      ,dh.[TenTinhtrangDonhang]
      ,dh.[KhoId]
      ,dh.[KhachhangId]
      ,dh.[Ngaygiao]
      ,dh.[TenTinhthanhGiao]
      ,dh.[TenQuanhuyenGiao]
      ,dh.[SoDienthoai]
      ,dh.[Tiengiam]
      ,dh.[PhantramGiam]
      ,dh.[Tongtien]
      ,dh.[Ghichu]
      ,dh.[LoaiDonhang]
      ,dh.[NhanvienCapnhatId]
      ,dh.[NgayCapnhat]
      ,dh.[Step]
      ,dh.[Version]
      ,dh.[HanDonhang]
      ,dh.[Active]
	  ,dh.[DiachiGiao]+ ' ' + dh.[TenQuanhuyenGiao] + ' ' + dh.[TenQuanhuyenGiao] as DiachiGiao
	  ,kh.HotenKhachhang as TenKhachhang
  FROM ([QLBH_08_2014].[dbo].[Donhang] as dh join [QLBH_08_2014].[dbo].[Phieuxuat] as px on dh.DonhangId = px.DonhangId) join Khachhang kh on kh.KhachhangId = dh.KhachhangId
	where px.PhieuxuatId = @PhieuxuatId


