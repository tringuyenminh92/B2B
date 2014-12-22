use QLBH_08_2014
go
create proc Tri_GetPhongbanActive
as
	select p.PhongbanId
      ,p.Code
      ,p.TenPhongban
      ,p.Ghichu
      ,p.NgayCapnhat
      ,p.Active
      ,p.Step
      ,p.Version
	from Phongban p
	where p.Active=1

