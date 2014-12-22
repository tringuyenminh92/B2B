use QLBH_08_2014
go
create proc Vinh_GetDonviActive
as
	select [DonviId]
	,[Code]
	,[TenDonvi]
	,[Active]
	,[Ghichu]
	,[Step]
	,[Version]
	,[NgayCapnhat]
	
	from Donvi d
	where d.Active=1

