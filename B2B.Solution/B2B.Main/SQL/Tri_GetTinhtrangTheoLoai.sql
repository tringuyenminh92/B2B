use QLBH_08_2014
go
create proc Tri_GetTinhtrangTheoLoai
	@LoaiTinhtrangValue int
as
	select	t.TinhtrangId
      ,t.Code
      ,t.TenTinhtrang
      ,t.Ghichu
      ,t.Active
      ,t.NgayCapnhat
      ,t.Step
      ,t.Version
	from Tinhtrang t
	where t.Step=@LoaiTinhtrangValue