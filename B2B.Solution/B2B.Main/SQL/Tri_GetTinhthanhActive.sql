use QLBH_08_2014
go
create proc Tri_GetTinhthanhActive
as
	select [TinhthanhId]
      ,[Code]
      ,[TenTinhthanh]
      ,[Ghichu]
      ,[Active]
      ,[Step]
      ,[Version]
      ,[KhuvucId]
      ,[NgayCapnhat]
	from Tinhthanh t
	where t.Active=1
	
