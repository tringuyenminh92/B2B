use QLBH_08_2014
go 
alter proc Tin_GetHanghoaTheoKho
@KhoId uniqueidentifier
as
begin
	select  a.[HanghoaId]
      ,a.[Code]
      ,a.[TenHanghoa]
      ,a.[NhomHanghoaId]
      ,a.[Giagoc]
      ,a.[Barcode]
      ,a.[DonviId]
      ,a.[LinkHinhanh]
      ,a.[Ghichu]
      ,a.[Active]
      ,a.[Step]
      ,a.[Version]
      ,a.[NgayCapnhat]
	  from Hanghoa a left join Tonkho b on a.HanghoaId = b.HanghoaId 
	  where b.KhoId = @KhoId
end