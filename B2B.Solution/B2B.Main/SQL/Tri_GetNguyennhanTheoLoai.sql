use QLBH_08_2014
go
create proc Tri_GetNguyennhanTheoLoai
	@LoaiNguyennhanValue int
as
	select	n.NguyennhanLydoId
      ,n.Code
      ,n.Noidung
      ,n.Active
      ,n.Ghichu
      ,n.Step
      ,n.Version
	from NguyennhanLydo n
	where n.Step=@LoaiNguyennhanValue or (@LoaiNguyennhanValue=-1)