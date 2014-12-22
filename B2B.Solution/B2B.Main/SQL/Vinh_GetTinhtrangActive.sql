use QLBH_08_2014
go
create proc Vinh_GetTinhtrangActive
as
	select tt.[TinhtrangId]
      ,tt.[Code]
      ,tt.[TenTinhtrang]
      ,tt.[Ghichu]
      ,tt.[Active]
      ,tt.[NgayCapnhat]
      ,tt.[Step]
      ,tt.[Version]
	  ,tt.[CanDelete]
	from Tinhtrang tt
	where tt.Active=1

