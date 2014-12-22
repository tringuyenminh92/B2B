use QLBH_08_2014
go
create proc Tin_DeletePhieunhap
@PhieunhapId uniqueidentifier
as
begin
delete from ChitietPhieunhap  where PhieunhapID=@PhieunhapId
delete from Phieunhap where PhieunhapId=@PhieunhapId
end

