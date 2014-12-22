use QLBH_08_2014
go
alter proc Tri_GetDongiaTheoNhomKhachhang
@NhomKhachhangId uniqueidentifier
as
	select   d.DongiaId
      ,d.Code
      ,d.Dongia
      ,d.NgayCapnhat
      ,d.ApdungTu
      ,d.HanghoaId
      ,d.NhomKhachhangId
      ,d.Ghichu
      ,d.Active
      ,d.Step
      ,d.Version
	  ,h.TenHanghoa as TenHanghoa
	  ,k.TenNhomKhachhang as TenNhomKhachhang
	from (Dongia d left join Hanghoa h on d.HanghoaId=h.HanghoaId) left join NhomKhachhang k on k.NhomKhachhangId=d.NhomKhachhangId
	where (d.NhomKhachhangId=@NhomKhachhangId)


