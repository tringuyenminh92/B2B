use QLBH_08_2014
go
alter proc Khuyen_GetBaogiaTheoNhomKhachhang
@NhomKhachhangId uniqueidentifier
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
	dv.TenDonvi as TenDonvi,
	d.Dongia as DonGia
	from Hanghoa h 
				left join Donvi dv on h.DonviId = dv.DonviId
				left join 
					( select * from Dongia where Dongia.NhomKhachhangId = @NhomKhachhangId
					and Dongia.ApdungTu <= GETDATE())
					d on d.HanghoaId = h.HanghoaId
	where h.Active = 1