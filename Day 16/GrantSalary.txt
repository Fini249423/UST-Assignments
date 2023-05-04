declare @eid int;
declare @grandsalary int;
declare @salary int;
declare employee_cursor CURSOR
FOR
select * from EMPMASTER;
OPEN employee_cursor;

SET @grandsalary= @grandsalary+@salary;
fetch next from employee_cursor into @eid;
CLOSE employee_cursor;
deallocate employee_cursor;
select @salary as @grandsalary;