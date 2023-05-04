create or alter procedure sp_PrintDate as
BEGIN
SELECT getdate();
END;
exec sp_PrintDate
