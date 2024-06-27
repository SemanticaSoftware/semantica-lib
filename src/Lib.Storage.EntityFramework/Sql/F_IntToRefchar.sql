-- ##down## --
drop function if exists [dbo].[F_IntToRefchar];
GO
-- ##/down## --
--- <summary>
---		Zet een integer om een alfanumeriek karakter.
---		Een karakter ([0-9A-Y] excl [IOV]) staat tot één 5-bit int (0-31).
---		Hogere orde bits worden genegeerd.
--- </summary>
--- <parameter name=@Value>Een (5 bit) integer</parameter>
create or alter function [dbo].[F_IntToRefchar](@Value int)
	returns varchar(1) 
	as
	begin
		return (
			--bitwise-And met 00011111 om alleen de laatste 5 bits over te houden (0-31)
			case @Value & 31 
				when 0 then '0'
				when 1 then '1'
				when 2 then '2'
				when 3 then '3'
				when 4 then '4'
				when 5 then '5'
				when 6 then '6'
				when 7 then '7'
				when 8 then '8'
				when 9 then '9'
				when 10 then 'A'
				when 11 then 'B'
				when 12 then 'C'
				when 13 then 'D'
				when 14 then 'E'
				when 15 then 'F'
				when 16 then 'G'
				when 17 then 'H'
				when 18 then 'J'
				when 19 then 'K'
				when 20 then 'L'
				when 21 then 'M'
				when 22 then 'N'
				when 23 then 'P'
				when 24 then 'Q'
				when 25 then 'R'
				when 26 then 'S'
				when 27 then 'T'
				when 28 then 'U'
				when 29 then 'W'
				when 30 then 'X'
				when 31 then 'Y'
			end
		);
	end;
