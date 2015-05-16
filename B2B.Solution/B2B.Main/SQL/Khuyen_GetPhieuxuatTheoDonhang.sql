USE [QLBH_08_2014]
GO
/****** Object:  StoredProcedure [dbo].[Khuyen_GetHanghoaTheoNhom]    Script Date: 20/09/2014 11:10:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khuyen_GetPhieuxuatTheoDonhang]
@DonhangId uniqueidentifier
as
	select  px.PhieuxuatId
      ,px.[Code]
      ,px.[NhanvienLapId]
      ,px.[KhoId]
      ,px.[DonhangId]
      ,px.[Ngaylap]
      ,px.[NhanvienGiaohangId]
      ,px.[TenTinhtrangPhieuxuat]
      ,px.[NgayCapnhat]
      ,px.[Ghichu]
      ,px.[Step]
      ,px.[Version]
	  ,px.[NguyennhanLydo]
	  ,px.[TinhtrangPhieuxuatCurrentId]
	  ,px.[NhanvienDonhang]
      ,px.[Tongtien]
	  ,nv.HovatenNhanvien as TenNhanvienLap
	  ,k.TenKho as TenKho
	  ,nv2.HovatenNhanvien as TenNhanvienGiaohang
	  ,dh.Code as CodeDonhang
	  ,dh.NgayLap as NgaylapDonhang
	  ,nn.Noidung as TenNguyennhanLydo
	from Phieuxuat px left join Nhanvien nv on px.NhanvienLapId = nv.NhanvienId
						left join Kho k on px.KhoId = k.KhoId
						left join Nhanvien nv2 on px.NhanvienGiaohangId = nv2.NhanvienId 
						left join Donhang dh on px.DonhangId = dh.DonhangId
						left join NguyennhanLydo nn on px.NguyennhanLydo = nn.NguyennhanLydoId
	where px.DonhangId = @DonhangId
	order by px.Ngaylap desc