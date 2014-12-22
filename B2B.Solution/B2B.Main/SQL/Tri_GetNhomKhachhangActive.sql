use QLBH_08_2014
go
create proc Tri_GetNhomKhachhangActive
as
	select [NhomKhachhangId]
      ,[Code]
      ,[TenNhomKhachhang]
      ,[Ghichu]
      ,[Active]
      ,[Step]
      ,[Version]
      ,[NgayCapnhat]
  FROM [NhomKhachhang] n
  where n.Active=1