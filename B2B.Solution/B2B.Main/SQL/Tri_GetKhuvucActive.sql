use QLBH_08_2014
go
create proc Tri_GetKhuvucActive
as
	select [KhuvucId]
      ,[Code]
      ,[TenKhuvuc]
      ,[Active]
      ,[Ghichu]
      ,[Step]
      ,[Version]
      ,[NgayCapnhat]
	from Khuvuc k
	where k.Active=1

