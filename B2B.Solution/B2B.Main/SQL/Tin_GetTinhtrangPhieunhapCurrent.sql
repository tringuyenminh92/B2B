use QLBH_08_2014
go
create proc Tin_GetTinhtrangPhieunhapCurrent
@PhieunhapId uniqueidentifier
as
begin
select TinhtrangPhieunhapId,
PhieunhapId,
TinhtrangId,
NhanvienCapnhat,
NgayCapnhat,
Version
from TinhtrangPhieunhap
where PhieunhapId=@PhieunhapId and NgayCapnhat=(select max(NgayCapnhat) from TinhtrangPhieunhap where PhieunhapId=@PhieunhapId)
end