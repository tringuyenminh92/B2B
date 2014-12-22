use QLBH_08_2014
go
create proc Khuyen_GetKhachhang
as
	SELECT kh.KhachhangId
      ,kh.Code
      ,kh.HotenKhachhang
      ,kh.CMND
      ,kh.Ngaysinh
      ,kh.Gioitinh
      ,kh.[Diachi]
      ,kh.[DiachiGiaohang]
      ,kh.[QuanhuyenId]
      ,kh.[TinhthanhId]
      ,kh.[NhomKhachhangId]
      ,kh.[Linkanh]
      ,kh.[Congty]
      ,kh.[Chucvu]
      ,kh.[Email]
      ,kh.[DiachiCongty]
      ,kh.[PhoneCongty]
      ,kh.[Tel]
      ,kh.[Mobile]
      ,kh.[Fax]
      ,kh.[MasoThue]
      ,kh.[TenTaikhoan]
      ,kh.[SoTaikhoan]
      ,kh.[Nganhang]
      ,kh.[HanmucCongno]
      ,kh.[ThoigianCongno]
      ,kh.[ToahangCongno]
      ,kh.[Ghichu]
      ,kh.[NgayCapnhat]
      ,kh.[Active]
      ,kh.[Step]
      ,kh.[Version]
	  ,nkh.TenNhomKhachhang
  FROM Khachhang kh left join NhomKhachhang nkh on kh.NhomKhachhangId = nkh.NhomKhachhangId

