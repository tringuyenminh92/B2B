use QLBH_08_2014
go
alter proc Tri_GetTinhthanhVoiTenKhuvuc
as
	select t.TinhthanhId
      ,t.Code
      ,t.TenTinhthanh
      ,t.Ghichu
      ,t.Active
      ,t.Step
      ,t.Version
      ,t.KhuvucId
      ,t.NgayCapnhat
	  ,k.TenKhuvuc as TenKhuvuc
	from Tinhthanh t left join Khuvuc k on t.KhuvucId=k.KhuvucId

