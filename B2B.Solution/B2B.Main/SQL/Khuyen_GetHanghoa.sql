use QLBH_08_2014
go
create proc Khuyen_GetHanghoa
as
	select  h.HanghoaId,
	h.Code,
	h.TenHanghoa,
	h.NhomHanghoaId,
	h.Giagoc,
	h.Barcode,
	h.DonviId,
	h.LinkHinhanh,
	h.Ghichu,
	h.Active,
	h.Step,
	h.Version,
	h.NgayCapnhat,
	nh.TenNhomHanghoa as TenNhomHanghoa,
	dv.TenDonvi as TenDonvi
	from Hanghoa h left join NhomHanghoa nh on h.NhomHanghoaId = nh.NhomHanghoaId
				left join Donvi dv on h.DonviId = dv.DonviId
	where h.Active = 1;

