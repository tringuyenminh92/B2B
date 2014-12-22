use QLBH_08_2014
go
create proc Vinh_GetDonhangTheoThang_koloaidonhang
	@Ngaylap datetime
as
begin
	declare @thang int,@nam int
	set @thang=Month(@Ngaylap)
	set @nam=Year(@Ngaylap)

	select d.DonhangId
      ,d.Code
      ,d.NhanvienId
      ,d.Ngaylap
      ,(select top 1 TenTinhtrangDonhang from Tinhtrang tt where d.TinhtrangDonhangCurrentId=tt.TinhtrangId) as TenTinhtrangDonhang
      ,d.KhoId
      ,d.KhachhangId
      ,d.Ngaygiao
      ,d.DiachiGiao
      ,d.TenQuanhuyenGiao
      ,d.TenTinhthanhGiao
      ,d.SoDienthoai
      ,d.Tiengiam
      ,d.PhantramGiam
      ,d.Tongtien
      ,d.Ghichu
      ,d.LoaiDonhang
      ,d.NhanvienCapnhatId
      ,d.NgayCapnhat
      ,d.Step
      ,d.Version
	  ,d.HanDonhang
	  ,d.TinhtrangDonhangCurrentId
	  ,n.HovatenNhanvien as TenNhanvienLap
	  ,nv.HovatenNhanvien as TenNhanvienCapnhat
	  ,k.HotenKhachhang as TenKhachhang
	  ,kh.TenKho as TenKho
	from Donhang d left join Nhanvien n on d.NhanvienId=n.NhanvienId
				left join Nhanvien nv on d.NhanvienCapnhatId=nv.NhanvienId
				left join Khachhang k on d.KhachhangId=k.KhachhangId
				left join Kho kh on d.KhoId=kh.KhoId
	where Month(d.Ngaylap)=@thang and Year(d.Ngaylap)=@nam
	order by d.Ngaylap ASC,d.HanDonhang ASC
end
	