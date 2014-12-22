use QLBH_08_2014
go
alter proc Tin_GetTonkhoMoinhatHanghoaTheoKho
@KhoId uniqueidentifier,
@HanghoaId uniqueidentifier
as
begin
    
	select [TonkhoId]
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
	from Tonkho
	where KhoId=@KhoId and HanghoaId=@HanghoaId and NgayCapnhat=(select Max(NgayCapnhat) from Tonkho where KhoId=@KhoId and HanghoaId=@HanghoaId)
end