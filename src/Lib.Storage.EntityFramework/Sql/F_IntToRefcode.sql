-- ##down## --
drop function if exists [dbo].[F_IntToRefcode];
GO
-- ##/down## --
--- <summary>
---		Zet een integerwaarde om naar een alfanumerieke code van maximaal 6 karakters.
---		Een karakter ([0-9A-Y] excl [IOV]) staat tot één 5-bit int (0-31).
---		Met de @Length parameter wordt het aantal te coderen karakters aangegeven. 
---		Alleen de eerste @lenght*5 bits van de int worden bekeken. Hogere orde bits worden genegeerd.
---		De code wordt altijd met nullen aangevult tot lengte @Length.
--- </summary>
--- <parameter name=@Value>Een integer</parameter>
--- <parameter name=@Length>Lengte van de output charstring</parameter>
create or alter function [dbo].[F_IntToRefcode](@Value int, @Length int)
	returns varchar(6) 
	as
	begin
		set @Length = IIF(@Length < 6 and @Length >= 0, @Length, 6);
		declare @refcode varchar(6), @refchar char(1);
		set @refcode = '';
		while LEN(@refcode) < @Length
		begin
			exec @refchar = [dbo].[F_IntToRefchar] @Value;
			set @refcode = CONCAT(@refchar, @refcode);
			set @Value = @Value / 32;
		end;
		return @refcode;
	end;
