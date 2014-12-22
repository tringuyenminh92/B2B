use QLBH_08_2014
go
alter proc Vinh_GetTonKhoMoiNhatTheoHangHoa_Kho
	@KhoId uniqueidentifier,
	@HanghoaId uniqueidentifier
as
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
	
from Tonkho  where KhoId = @KhoId and HanghoaId = @HanghoaId
	group by NgayCapnhat
	  ,[TonkhoId]
      ,[HanghoaId]
      ,[KhoId]
      ,[Ngay]
      ,[Thang]
      ,[Nam]
      ,[GioCapnhat]
      ,[SoduDauky]
      ,[SoluongNhap]
      ,[SoluongXuat]
      ,[SoluongTon]
      ,[NhanvienCapnhat]
      ,[Step]
      ,[Version]
      ,[Active]
	having NgayCapnhat = MAX(NgayCapnhat) and GioCapnhat = MAX(GioCapnhat)