use QLBH_08_2014
go
alter proc Tri_GetQuanhuyenTheoTinhthanh
	@TinhthanhId uniqueidentifier
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
	where  q.TinhthanhId=@TinhthanhId

