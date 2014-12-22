use QLBH_08_2014
go
create proc Tri_GetQuanhuyenActive
as
	select [QuanhuyenId]
      ,[Code]
      ,[TenQuanhuyen]
      ,[Active]
      ,[Ghichu]
      ,[TinhthanhId]
      ,[Step]
      ,[Version]
      ,[NgayCapnhat]
	from Quanhuyen q
	where  q.Active=1

