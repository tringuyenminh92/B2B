use QLBH_08_2014
go
create proc Vinh_GetChitietPhieuxuatTheoDonHang
	@DonhangId uniqueidentifier
as
select ab.id as HanghoaId,ab.tenhh as TenHanghoa, (cd.Soluong - ab.tong) as SoLuongCanXuat
from ChitietDonhang cd join (select cp.HanghoaId as id,h.TenHanghoa as tenhh, Sum(cp.Soluong) as tong
	from ChitietPhieuxuat cp join Phieuxuat P on p.PhieuxuatId = cp.PhieuxuatId
		join Hanghoa h on h.HanghoaId = cp.HanghoaId
	where p.DonhangId = @DonhangId
	group by cp.HanghoaId,h.TenHanghoa
)as ab on ab.id = cd.HanghoaIdu 
	