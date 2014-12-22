use QLBH_08_2014
go
create function Tri_GetSoduDaukyTheoNgay(@HanghoaId uniqueidentifier,@Ngay datetime)
	returns int
as
	begin
		declare @vaongay int
		declare @sodu int
		set @vaongay=YEAR(@Ngay) * 10000 + MONTH(@Ngay)*100 + Day(@Ngay)
		select @sodu=sum(SoduTheoKho.SoduTungkho)
		from (	select k.KhoId,(select top 1 t.SoduDauky 
								from Tonkho t 
								where t.Ngay+t.Thang*100+t.Nam*10000 < @vaongay and t.HanghoaId=@HanghoaId and t.KhoId=k.KhoId 
								order by YEAR(t.NgayCapnhat) desc, MONTH(t.NgayCapnhat) desc, Day(t.NgayCapnhat) desc,convert(varchar(8), t.NgayCapnhat,108) desc) as SoduTungkho
				from Kho k) as SoduTheoKho
		return @sodu
	end
