use QLBH_08_2014
go
create proc Vinh_GetKhoActive
as
	select k.[KhoId]
      ,k.[Code]
      ,k.[TenKho]
      ,k.[Diachi]
      ,k.[QuanhuyenId]
      ,k.[TinhthanhId]
      ,k.[Ghichu]
      ,k.[NgayCapnhat]
      ,k.[Active]
      ,k.[Step]
      ,k.[Version]
	from Kho k where k.Active = 1

