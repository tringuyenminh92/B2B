use QLBH_08_2014
go
create function Tri_GetSoluongTon(@HanghoaId uniqueidentifier,@Ngay datetime)
	returns int
as
	begin
		declare @vaongay int
		declare @soton int
		set @vaongay=YEAR(@Ngay) * 10000 + MONTH(@Ngay)*100 + Day(@Ngay)
		select @soton=sum(SotonTheoKho.soton)
		from (	select k.KhoId,(select top 1 t.SoluongTon 
								from Tonkho t 
								where t.Ngay+t.Thang*100+t.Nam*10000 = @vaongay and t.HanghoaId=@HanghoaId and t.KhoId=k.KhoId 
								order by t.Nam desc, t.Thang desc, t.Ngay desc, convert(varchar(8), t.NgayCapnhat,108) desc) as soton
				from Kho k) as SotonTheoKho
		return @soton
	end
