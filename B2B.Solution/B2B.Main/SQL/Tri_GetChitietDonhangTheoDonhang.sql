use QLBH_08_2014
go
create proc Tri_GetChitietDonhangTheoDonhang
	@DonhangId uniqueidentifier
as
begin
	select *,h.Code as Mahang
	from ChitietDonhang ct join Hanghoa h on ct.HanghoaId=h.HanghoaId
	where ct.DonhangId=@DonhangId
end
	