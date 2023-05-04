create or alter procedure sp_GetSalary
@empid int, @sal money output
as
begin
select @sal=SALARY from EMPMASTER where EMPID=@empid;
end;
