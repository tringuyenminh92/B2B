use QLBH_08_2014
go
create proc Vinh_GetNhomHanghoaActive
as
	select [NhomHanghoaId]
	,[Code]
	,[TenNhomHanghoa]
	,[Active]
	,[Ghichu]
	,[Step]
	,[Version]
	,[NgayCapnhat]
	
	from NhomHanghoa n
	where n.Active=1

