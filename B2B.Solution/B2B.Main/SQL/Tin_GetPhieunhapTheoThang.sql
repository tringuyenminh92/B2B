use QLBH_08_2014
go
create proc [dbo].[Tin_GetPhieunhapTheoThang]
	@Ngaylap datetime
as
begin
	declare @thang int,@nam int
	set @thang=Month(@Ngaylap)
	set @nam=Year(@Ngaylap)

	select  d.PhieunhapId
      ,d.Code
      ,d.NhanvienId
	  ,d.KhoId
	  ,d.NhaCungcapId
	  ,d.Ngaylap
      ,d.Ghichu
      ,d.Step
      ,d.Version
	  ,d.TinhtrangPhieunhapCurrentId
	  ,n.HovatenNhanvien as TenNhanvien
	  ,k.TenKho
	  ,h.TenNhaCungcap
	  ,d.TinhtrangPhieunhapCurrentId
	  ,l.TenTinhtrang
	from Phieunhap d left join Nhanvien n on d.NhanvienId=n.NhanvienId
				left join Nhanvien nv on d.NhanvienId=nv.NhanvienId
				left join Kho k on d.KhoId=k.KhoId
				left join NhaCungcap h on d.NhacungcapId=h.NhaCungcapId
				left join Tinhtrang l on d.TinhtrangPhieunhapCurrentId=l.TinhtrangId
	where Month(d.Ngaylap)=@thang and Year(d.Ngaylap)=@nam
end
