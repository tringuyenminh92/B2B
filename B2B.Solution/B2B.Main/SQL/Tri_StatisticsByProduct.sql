use QLBH_08_2014
go
create proc Tri_StatisticsByProduct
as
select *
from Tonkho tk	right join Hanghoa hh on tk.HanghoaId=hh.HanghoaId
					  join NhomHanghoa nhh on hh.HanghoaId=nhh.NhomHanghoaId
				right join Kho k on tk.KhoId=k.KhoId
				  	  join Quanhuyen qh on k.QuanhuyenId=qh.QuanhuyenId
					  join Tinhthanh tt on k.TinhthanhId=tt.TinhthanhId
					  join Khuvuc kv on tt.KhuvucId=kv.KhuvucId
				right join Nhanvien nv on tk.NhanvienCapnhat=nv.NhanvienId


