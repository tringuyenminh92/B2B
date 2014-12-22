use QLBH_08_2014
go
create proc Tri_GetKhachhangTheoNhomKhachhang
	@NhomKhachhangId uniqueidentifier
as
	select  k.KhachhangId
      ,k.Code
      ,k.HotenKhachhang
      ,k.CMND
      ,k.Ngaysinh
      ,k.Gioitinh
      ,k.Diachi
      ,k.DiachiGiaohang
      ,k.QuanhuyenId
      ,k.TinhthanhId
      ,k.NhomKhachhangId
      ,k.Linkanh
      ,k.Congty
      ,k.Chucvu
      ,k.Email
      ,k.DiachiCongty
      ,k.PhoneCongty
      ,k.Tel
      ,k.Mobile
      ,k.Fax
      ,k.MasoThue
      ,k.TenTaikhoan
      ,k.SoTaikhoan
      ,k.Nganhang
      ,k.HanmucCongno
      ,k.ThoigianCongno
      ,k.ToahangCongno
      ,k.Ghichu
      ,k.NgayCapnhat
      ,k.Active
      ,k.Step
      ,k.Version
	  ,q.TenQuanhuyen as TenQuanhuyen
	  ,t.TenTinhthanh as TenTinhthanh
	  ,n.TenNhomKhachhang as TenNhomKhachhang
	from Khachhang k left join Quanhuyen q on k.QuanhuyenId= q.QuanhuyenId
					left join Tinhthanh t on k.TinhthanhId=t.TinhthanhId
					left join NhomKhachhang n on k.NhomKhachhangId=n.NhomKhachhangId
	where k.NhomKhachhangId=@NhomKhachhangId or @NhomKhachhangId=N'00000000-0000-0000-0000-000000000000'

