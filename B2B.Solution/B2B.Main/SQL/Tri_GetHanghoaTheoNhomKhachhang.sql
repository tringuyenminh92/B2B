use QLBH_08_2014
go
alter proc Tri_GetHanghoaTheoNhomKhachhang
	@NhomKhachhangId uniqueidentifier
as
	select  h.HanghoaId
      , h.Code
      , h.TenHanghoa
      , h.NhomHanghoaId
      , h.Giagoc
      , h.Barcode
      , h.DonviId
      , h.LinkHinhanh
      , h.Ghichu
      , h.Active
      , h.Step
      , h.Version
      , h.NgayCapnhat
	,(select d.Dongia
				from Dongia d 
				where d.HanghoaId=h.HanghoaId and d.ApdungTu<=Getdate() and d.NhomKhachhangId=@NhomKhachhangId
				group by d.Dongia,d.NgayCapnhat
				having d.NgayCapnhat=max(d.NgayCapnhat)
				) as Dongia,
			n.TenNhomHanghoa as TenNhomHanghoa,
			dv.TenDonvi as TenDonvi
	from Hanghoa h left join NhomHanghoa n on h.NhomHanghoaId=n.NhomHanghoaId
					left join Donvi dv on h.DonviId=dv.DonviId