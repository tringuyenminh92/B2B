use QLBH_08_2014
go
alter proc Tri_GetTinhthanhTheoKhuvuc
	@KhuvucId uniqueidentifier
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
	where t.Active=1 and t.KhuvucId=@KhuvucId 

