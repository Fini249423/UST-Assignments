--Write a PL/SQL block to pass an age as parameter in procedure and decide person can vote or not.

create or alter procedure Vote(@n int)
AS
BEGIN
if @n>=18
   print 'Eligible to vote'
else
   print 'Not Eligible to vote'
END

Exec Vote 3