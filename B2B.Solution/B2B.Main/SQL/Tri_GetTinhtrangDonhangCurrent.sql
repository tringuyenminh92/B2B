use QLBH_08_2014
go
create proc Tri_GetTinhtrangDonhangCurrent
	@DonhangId uniqueidentifier
as
	begin
	select [TinhtrangDonhangId]
      ,[DonhangId]
      ,[TinhtrangId]
      ,[NgayCapnhat]
      ,[NhanvienCapnhatId]
      ,[Ghichu]
      ,[Version]
	from TinhtrangDonhang
	where DonhangId=@DonhangId and NgayCapnhat=(select max(NgayCapnhat) from TinhtrangDonhang where DonhangId=@DonhangId)
	end