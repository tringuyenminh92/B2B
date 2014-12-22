use QLBH_08_2014
go
create proc Tin_GetNhomKhachhangActive
as
	select [NhomKhachhangId]
      ,[Code]
      ,[TenNhomKhachhang]
      ,[Ghichu]
      ,[Active]
      ,[Step]
      ,[Version]
      ,[NgayCapnhat]
	from NhomKhachhang t
	where t.Active=1
