
use QLBH_08_2014
go
Create proc Tin_GetThuoctinHanghoaTheoHanghoa
@HanghoaId uniqueidentifier
as
select   d.ThuoctinhHanghoaId
      ,d.Code
      ,d.TenThuoctinh
      ,d.NgayCapnhat
      ,d.HanghoaId
      ,d.Ghichu
      ,d.Active
      ,d.Step
      ,d.Version
	  ,h.TenHanghoa as TenHanghoa
	from ThuoctinhHanghoa d left join Hanghoa h on d.HanghoaId=h.HanghoaId
	where d.HanghoaId=@HanghoaId or @HanghoaId=N'00000000-0000-0000-0000-000000000000'