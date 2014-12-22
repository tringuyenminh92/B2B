use QLBH_08_2014
go
create proc Tri_GetTinhtrangDalap
	@Code nvarchar(50)
as
	select	 tt.TinhtrangId
      ,tt.Code
      ,tt.TenTinhtrang
      ,tt.Ghichu
      ,tt.Active
      ,tt.NgayCapnhat
      ,tt.Step
      ,tt.Version
      ,tt.CanDelete
	from Tinhtrang tt
	where  tt.Code=@Code