use QLBH_08_2014
go
create proc Tri_GetNhanvien
as
	select  n.NhanvienId
      ,n.Code
      ,n.TenNhanvien
      ,n.HoNhanvien
      ,n.HovatenNhanvien
      ,n.CMND
      ,n.Ngaysinh
      ,n.Gioitinh
      ,n.Email
      ,n.Tel
      ,n.Mobile
      ,n.Diachi
      ,n.QuanhuyenId
      ,n.TinhthanhId
      ,n.NgayBatdau
      ,n.NgayKetthuc
      ,n.NgayCapnhat
      ,n.Ghichu
      ,n.Active
      ,n.Step
      ,n.Version
      ,n.Linkanh
	  ,t.TenTinhthanh as TenTinhthanh
	  ,q.TenQuanhuyen as TenQuanhuyen
	from Nhanvien n left join Tinhthanh t on n.TinhthanhId=t.TinhthanhId
				left join Quanhuyen q on n.QuanhuyenId=q.QuanhuyenId

