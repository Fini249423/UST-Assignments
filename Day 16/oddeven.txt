--Write a PL/SQL block to check the given number is even or odd.

create or alter procedure OddEven(@n int)
AS
BEGIN
if @n%2=0
   print 'Even Number'
else
   print 'Odd Number'
END

Exec OddEven 3