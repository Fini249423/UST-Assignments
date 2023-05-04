declare @eid int;
declare employee_cursor CURSOR
FOR
select EMPID from EMPMASTER order by EMPID;
OPEN employee_cursor;
fetch next from employee_cursor into @eid;
CLOSE employee_cursor;
deallocate employee_cursor;