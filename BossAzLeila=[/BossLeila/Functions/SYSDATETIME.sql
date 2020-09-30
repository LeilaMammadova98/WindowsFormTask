CREATE FUNCTION [BossLeila].[SYSDATETIME]
()
RETURNS datetime
AS
BEGIN
	RETURN dateadd(HOUR,4,getutcdate())
END
