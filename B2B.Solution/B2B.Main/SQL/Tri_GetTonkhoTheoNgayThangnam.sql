use QLBH_08_2014
go
alter proc Tri_GetTonkhoTheoNgay
	@Ngay datetime
as
	select h.TenHanghoa
	,sum(t.SoluongNhap) as Tongnhap
	,sum(t.SoluongXuat) as Tongxuat
	,sum(t.ThanhtienNhap) as TongtienNhap
	,sum(t.ThanhtienXuat) as TongtienXuat
	,[dbo].Tri_GetSoduDaukyTheoNgay(h.HanghoaId,@Ngay) as SoduBandau
	,[dbo].Tri_GetSoluongTon(h.HanghoaId,@Ngay) as SoluongTon
	from Hanghoa h left join (select * from Tonkho tk where tk.NgayCapnhat=@Ngay) as t on h.HanghoaId=t.HanghoaId
	group by h.HanghoaId,h.TenHanghoa
