USE [QLBH_08_2014]
GO
/****** Object:  StoredProcedure [dbo].[Khuyen_GetHanghoaTheoNhom]    Script Date: 20/09/2014 11:10:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Khuyen_GetNhacungcapTheoPhieunhap]
@PhieunhapId uniqueidentifier
as
	select  ncc.[NhaCungcapId]
      ,ncc.[Code]
      ,ncc.[TenNhaCungcap]
      ,ncc.[Diachi]
      ,ncc.[QuanhuyenId]
      ,ncc.[TinhthanhId]
      ,ncc.[TenCongty]
      ,ncc.[Fax]
      ,ncc.[Tel]
      ,ncc.[Mobile]
      ,ncc.[Email]
      ,ncc.[Website]
      ,ncc.[TenTaikhoan]
      ,ncc.[SoTaikhoan]
      ,ncc.[Nganhang]
      ,ncc.[Ghichu]
      ,ncc.[Active]
      ,ncc.[Step]
      ,ncc.[Version]
      ,ncc.[NgayCapnhat]
	from 
	(select * from Phieunhap pn 
	where pn.PhieunhapId = @PhieunhapId) A join NhaCungcap ncc on A.NhacungcapId = ncc.NhaCungcapId