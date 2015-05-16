USE [QLBH_08_2014]
GO
/****** Object:  StoredProcedure [dbo].[Khuyen_GetHanghoaTheoNhom]    Script Date: 20/09/2014 11:10:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khuyen_GetKhachhangTheoPhieuxuat]
@PhieuxuatId uniqueidentifier
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
	from 
	(select * from Phieuxuat px 
	where px.PhieuxuatId = @PhieuxuatId) A join Donhang dh on A.DonhangId = dh.DonhangId join Khachhang k on dh.KhachhangId = k.KhachhangId