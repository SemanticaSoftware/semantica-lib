-- ##down## --
drop function if exists [dbo].[F_IsValidRefcode];
GO
-- ##/down## --
--- <summary>
---		Bekijkt een referentiecode en controleert of alle karakters een geldige waarde hebben
---		Een karakter ([0-9A-Y] excl [IOV]) staat tot één 5-bit int ().
--- </summary>
--- <parameter name=@refchar>Een alfanumerieke char(1)</parameter>
create or alter function [dbo].[F_IsValidRefcode](@Refcode varchar(6))
	returns bit
	as
	begin
		return IIF(@Refcode like '%[^0123456789ABCDEFGHJKLMNPQRSTUWXY]%', 0, 1);
	end;
