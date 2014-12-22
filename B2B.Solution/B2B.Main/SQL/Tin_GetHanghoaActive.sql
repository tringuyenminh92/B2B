use QLBH_08_2014
go
create proc Tin_GetHanghoaActive
as
	select [HanghoaId]
      ,[Code]
      ,[TenHanghoa]
	  ,[NhomhanghoaId]
	  ,[Barcode]
	  ,[Giagoc]
	  ,[DonviId]
	  ,[LinkHinhanh]
      ,[Ghichu]
      ,[Active]
      ,[Step]
      ,[Version]
      ,[NgayCapnhat]
	from Hanghoa t
	where t.Active=1