USE [QLBH_08_2014]
GO
/****** Object:  StoredProcedure [dbo].[Khuyen_GetHanghoaTheoNhom]    Script Date: 20/09/2014 11:10:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Khuyen_GetHanghoaTheoNhom]
@NhomHanghoaId uniqueidentifier
as
	select  h.HanghoaId,
	h.Code,
	h.TenHanghoa,
	h.NhomHanghoaId,
	h.Giagoc,
	h.Barcode,
	h.DonviId,
	h.LinkHinhanh,
	h.Ghichu,
	h.Active,
	h.Step,
	h.Version,
	h.NgayCapnhat,
	nh.TenNhomHanghoa as TenNhomHanghoa,
	dv.TenDonvi as TenDonvi
	from Hanghoa h left join NhomHanghoa nh on h.NhomHanghoaId = nh.NhomHanghoaId
				left join Donvi dv on h.DonviId = dv.DonviId
	where h.NhomHanghoaId = @NhomHanghoaId or @NhomHanghoaId = '00000000-0000-0000-0000-000000000000'