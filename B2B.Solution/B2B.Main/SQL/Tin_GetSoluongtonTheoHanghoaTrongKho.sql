use 
QLBH_08_2014
go
alter proc Tin_GetSoluongtonTheoHanghoaTrongKho
@KhoId UniqueIdentifier,
@HanghoaId UniqueIdentifier
as
begin
SELECT [TonkhoId]
      ,[HanghoaId]
      ,[KhoId]
      ,[Ngay]
      ,[Thang]
      ,[Nam]
      ,[NgayCapnhat]
      ,[GioCapnhat]
      ,[SoduDauky]
      ,[SoluongNhap]
      ,[SoluongXuat]
      ,[SoluongTon]
      ,[NhanvienCapnhat]
      ,[Step]
      ,[Version]
      ,[Active]
      ,[SoluongTonDukien]
      ,[ThanhtienNhap]
      ,[ThanhtienXuat]
  FROM [QLBH_08_2014].[dbo].[Tonkho]
  WHERE [KhoId]=@KhoId and [HanghoaId]=@HanghoaId
  Order by [NgayCapnhat] desc
end
