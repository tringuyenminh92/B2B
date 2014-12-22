use QLBH_08_2014
go
create proc Vinh_GetNguyennhanLydoActive
as
	select nn.[NguyennhanLydoId]
      ,nn.[Code]
      ,nn.[Noidung]
      ,nn.[Active]
      ,nn.[Ghichu]
      ,nn.[Step]
      ,nn.[Version]
	
	from NguyennhanLydo nn
	where nn.Active=1

