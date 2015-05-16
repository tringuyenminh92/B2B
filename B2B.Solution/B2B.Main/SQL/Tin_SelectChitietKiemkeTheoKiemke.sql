use QLBH_08_2014
go
alter proc Tin_SelectChitietKiemkeTheoKiemke
@KiemkeId UniqueIdentifier
as
begin
SELECT ct.[ChitietKiemkeId]
      ,ct.[KiemkeId]
      ,ct.[HanghoaId]
      ,ct.[TenHanghoa]
      ,ct.[SoluongTon]
      ,ct.[SoluongThuc]
      ,ct.[Ghichu]
      ,ct.[Step]
      ,ct.[Version]
  FROM [QLBH_08_2014].[dbo].[ChitietKiemke] ct
  where ct.KiemkeId=@KiemkeId
end 