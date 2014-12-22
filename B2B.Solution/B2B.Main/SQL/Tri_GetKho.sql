use QLBH_08_2014
go
alter proc Tri_GetKho
as
	select   k.KhoId
      ,k.Code
      ,k.TenKho
      ,k.Diachi
      ,k.QuanhuyenId
      ,k.TinhthanhId
      ,k.Ghichu
      ,k.NgayCapnhat
      ,k.Active
      ,k.Step
      ,k.Version
	  ,t.TenTinhthanh as TenTinhthanh
	  ,q.TenQuanhuyen as TenQuanhuyen
	from Kho k left join Tinhthanh t on k.TinhthanhId=t.TinhthanhId
			left join Quanhuyen q on k.QuanhuyenId= q.QuanhuyenId

