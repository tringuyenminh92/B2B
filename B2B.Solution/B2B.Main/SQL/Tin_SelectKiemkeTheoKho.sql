use QLBH_08_2014
go
create proc Tin_SelectKiemkeTheoKho
@KhoId UniqueIdentifier
as
begin
SELECT a.[KiemkeId]
      ,a.[Code]
      ,a.[KhoId]
	  ,b.TenKho
      ,a.[Ngaylap]
      ,a.[NhanvienId]
	  ,c.[TenNhanvien]
      ,a.[Step]
      ,a.[Version]
      ,a.[Active]
  FROM Kiemke a left join Kho b on b.KhoId=a.KhoId
				left join Nhanvien c on c.NhanvienId=a.NhanvienId
  WHERE a.KhoId=@KhoId
  end
