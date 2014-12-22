use QLBH_08_2014
go
create proc Tri_GetNhanvienTheoPhongban
	@PhongbanId uniqueidentifier
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
	  ,p.TenPhongban as TenPhongban
	from Nhanvien n left join Tinhthanh t on n.TinhthanhId=t.TinhthanhId
				left join Quanhuyen q on n.QuanhuyenId=q.QuanhuyenId
				left join Phongban p on n.PhongbanId=p.PhongbanId
	where  n.PhongbanId=@PhongbanId or (@PhongbanId=N'00000000-0000-0000-0000-000000000000')
