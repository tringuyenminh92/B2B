use QLBH_08_2014
go
create proc Tin_GetChitietPhieunhapTheoPhieunhap
	@PhieunhapId uniqueidentifier
as
begin
select ChitietPhieunhapId,
		a.PhieunhapId,
		a.HanghoaId,
		b.TenHanghoa,
		a.Soluong,
		a.Barcode,
		a.NSX,
		a.HSD,
		a.Gianhap,
		a.Thanhtien,
		a.Ghichu,
		a.Step,
		a.Version
from ChitietPhieunhap a left join Hanghoa b on a.HanghoaId=b.HanghoaId
where a.PhieunhapId=@PhieunhapId
end