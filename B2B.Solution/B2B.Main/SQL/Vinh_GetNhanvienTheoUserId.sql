use QLBH_08_2014
go
create proc Vinh_GetNhanvienTheoUserId
@UserId uniqueidentifier
as
	select  n.[NhanvienId]
      ,n.[Code]
      ,n.[TenNhanvien]
      ,n.[HoNhanvien]
      ,n.[HovatenNhanvien]
      ,n.[CMND]
      ,n.[Ngaysinh]
      ,n.[Gioitinh]
      ,n.[Email]
      ,n.[Tel]
      ,n.[Mobile]
      ,n.[Diachi]
      ,n.[QuanhuyenId]
      ,n.[TinhthanhId]
      ,n.[NgayBatdau]
      ,n.[NgayKetthuc]
      ,n.[NgayCapnhat]
      ,n.[Ghichu]
      ,n.[Active]
      ,n.[Step]
      ,n.[Version]
      ,n.[Linkanh]
	from Nhanvien n 
				left join  [User] u on u.NhanvienId = n.NhanvienId
	where u.UserId = @UserId