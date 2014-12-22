use QLBH_08_2014
go
create proc Tin_GetPhieunhapTheoMa
@PhieunhapId uniqueidentifier
as
begin
	SELECT [PhieunhapId]
    ,[Code]
      ,[NhanvienId]
      ,[KhoId]
      ,[NhacungcapId]
      ,[Ngaylap]
      ,[Ghichu]
      ,[Step]
      ,[Version]
      ,[NguyennhanLydo]
      ,[Tongtien]
      ,[TinhtrangPhieunhapCurrentId]
  FROM [QLBH_08_2014].[dbo].[Phieunhap]
  WHERE PhieunhapId=@PhieunhapId
  end