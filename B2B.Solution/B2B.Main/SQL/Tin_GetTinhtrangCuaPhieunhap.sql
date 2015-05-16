use QLBH_08_2014
go
alter proc Tin_GetTinhtrangCuaPhieunhap
as
begin
	select *
	from Tinhtrang
	where Code like('TTPN%')
end;