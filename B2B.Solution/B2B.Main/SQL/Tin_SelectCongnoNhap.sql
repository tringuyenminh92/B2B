use QLBH_08_2014
go
alter proc Tin_SelectCongnoNhap
as
begin
SELECT cn.[CongnoNhapId]
      ,cn.[NhaCungcapId]
      ,cn.[NgayGiaodich]
      ,cn.[SoduTruocGiaodich]
      ,cn.[SotienGiaodich]
      ,cn.[Tongno]
      ,cn.[NgayHentra]
      ,cn.[NhanvienId]
      ,cn.[Ghichu]
      ,cn.[Step]
      ,cn.[Version]
	  ,A.TenNhaCungcap
	  ,nv.TenNhanvien
	FROM (select ncc.TenNhaCungcap, (select top 1 c.[CongnoNhapId]
									from CongnoNhap c 
									where c.NhaCungcapId = ncc.NhaCungcapId 
									order by c.NgayGiaodich desc) as CNNId
	from NhaCungcap ncc) as A left join CongnoNhap cn on A.CNNId = cn.CongnoNhapId left join Nhanvien nv on cn.NhanvienId = nv.NhanvienId
end