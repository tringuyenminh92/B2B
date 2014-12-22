use QLBH_08_2014
go
alter proc Tri_GetNhanvienActive
as
	select *
	from Nhanvien n
	where n.Active=1

