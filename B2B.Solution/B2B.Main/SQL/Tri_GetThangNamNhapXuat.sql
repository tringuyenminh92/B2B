use QLBH_08_2014
go
alter proc Tri_GetThangNamNhapXuat
as
	declare @tempTable table
	(
		inYear int,
		inMonth int,
		onNgay int,
		tongNhap float,
		tongXuat float
	)
	
	--intit when number of rows = 0
	declare @numRow int
	select @numRow=count(*) from @tempTable
	if(@numRow=0) insert into @tempTable(inMonth,inYear,onNgay,tongNhap,tongXuat) values(Month(getdate()),year(getdate()),day(getdate()),0,0) 

	insert into @tempTable
	select tk.Nam as inYear,tk.Thang as inMonth,tk.Ngay as onNgay,sum(tk.ThanhtienNhap) as Tongnhap,sum(tk.ThanhtienXuat) as Tongxuat
	from Tonkho tk
	group by tk.Ngay,tk.Nam,tk.Thang
	order by tk.Ngay,tk.Nam,tk.Thang
	
	declare @minYear int,@maxYear int
	select @minYear=Min(t.inYear),@maxYear=Max(t.inYear) from @tempTable t

	--init value table temple
	while(@minYear<=@maxYear)
	begin
		declare @month int 
		set @month=1
		while(@month<=12)
		begin
			declare @firstDay int,@lastDay int,@d date
			set @d= DATEFROMPARTS(@minYear,@month,6)
			set @firstDay=DAY(DATEADD(dd, -DAY(@d) + 1, @d))
			set @lastDay=DAY(DATEADD(dd, -DAY(@d), DATEADD(mm, 1, @d)))
			while(@firstDay<=@lastDay)
			begin
				if not exists (select * from @tempTable tb where (tb.inMonth=@month and tb.inYear=@minYear and tb.onNgay=@firstDay))
					begin
						insert into @tempTable(inYear,inMonth,onNgay,tongNhap,tongXuat) values(@minYear,@month,@firstDay,0,0)
					end
				set @firstDay=@firstDay+1
			end
			set @month=@month+1
		end
		set @minYear=@minYear+1
	end

	--return table tmp
	select e.inYear,e.inMonth,e.onNgay,e.tongNhap,e.tongXuat from @tempTable e
	order by e.inYear,e.inMonth,e.onNgay
	
	return
