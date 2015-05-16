use QLBH_08_2014
go
alter proc Tin_GetCongnoNhapMoinhatTheoNhacungcap
@NhacungcapId UniqueIdentifier
as
begin
SELECT [CongnoNhapId]
      ,[NhaCungcapId]
      ,[NgayGiaodich]
      ,[SoduTruocGiaodich]
      ,[SotienGiaodich]
      ,[Tongno]
      ,[NgayHentra]
      ,[NhanvienId]
      ,[Ghichu]
      ,[Step]
      ,[Version]
  FROM [QLBH_08_2014].[dbo].[CongnoNhap]
  WHERE NhaCungcapId=@NhacungcapId and [NgayGiaodich]=(select Max([NgayGiaodich]) from CongnoNhap where NhaCungcapId=@NhacungcapId)
end