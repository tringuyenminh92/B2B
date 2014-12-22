use QLBH_08_2014
go
create proc [dbo].[Vinh_GetDonhangTheoDonhangId]
@DonhangId uniqueidentifier
as
	select [DonhangId]
      ,[Code]
      ,[NhanvienId]
      ,[Ngaylap]
      ,[TenTinhtrangDonhang]
      ,[KhoId]
      ,[KhachhangId]
      ,[Ngaygiao]
      ,[DiachiGiao]
      ,[TenTinhthanhGiao]
      ,[TenQuanhuyenGiao]
      ,[SoDienthoai]
      ,[Tiengiam]
      ,[PhantramGiam]
      ,[Tongtien]
      ,[Ghichu]
      ,[LoaiDonhang]
      ,[NhanvienCapnhatId]
      ,[NgayCapnhat]
      ,[Step]
      ,[Version]
      ,[HanDonhang]
      ,[Active]
  FROM [QLBH_08_2014].[dbo].[Donhang]
	where DonhangId = @DonhangId


