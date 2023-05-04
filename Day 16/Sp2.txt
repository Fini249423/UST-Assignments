create or alter procedure ShowAcno(@Acno int)
AS
BEGIN
SELECT * FROM BankTB  Where Acno = @Acno;
END

Exec ShowAcno 101;