USE [QLBH_08_2014]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckLogin]    Script Date: 20/08/2014 2:40:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER function [dbo].[CheckLogin]

(@username varchar(max), @pass varchar(max))
RETURNs uniqueidentifier
WITH EXECUTE AS CALLER
begin
/*	declare @userID bigint
	if( @username = '42810cb02db3bb2cbb428af0d8b0376e' and @pass = '42810cb02db3bb2cbb428af0d8b0376e')
	BEGIN
		
		return 1;
	END
		
	return NULL;
	*/
	declare @userID uniqueidentifier
	select top 1 @userID = u.UserId
	from [User] u
	where u._Username = @username AND u.[_Password] = @pass
	
	return @userID
	
	
end