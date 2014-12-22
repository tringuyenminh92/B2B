use QLBH_08_2014
go
alter proc Tri_GetNhaCungcap
as
	select  n.NhaCungcapId
      ,n.Code
      ,n.TenNhaCungcap
      ,n.Diachi
      ,n.QuanhuyenId
      ,n.TinhthanhId
      ,n.TenCongty
      ,n.Fax
      ,n.Tel
      ,n.Mobile
      ,n.Email
      ,n.Website
      ,n.TenTaikhoan
      ,n.SoTaikhoan
      ,n.Nganhang
      ,n.Ghichu
      ,n.Active
      ,n.Step
      ,n.Version
      ,n.NgayCapnhat
	  ,t.TenTinhthanh as TenTinhthanh
	  ,q.TenQuanhuyen as TenQuanhuyen
	from NhaCungcap n left join Tinhthanh t on n.TinhthanhId=t.TinhthanhId
					left join Quanhuyen q on n.QuanhuyenId=q.QuanhuyenId

