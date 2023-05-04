--create table student(Id integer primary key,name varchar(20),class integer,division varchar(5));
--insert into student values(1,'Swetha',2,'A');
--insert into student values(2,'Samantha',3,'B');
--select * from student;
--create table teacher(Id integer primary key,name varchar(20),class integer,division varchar(5));
--insert into teacher values(101,'Lekshmi',2,'A');
--insert into teacher values(102,'Rahul',3,'B');
--select * from teacher;
--drop table student;
SELECT student.name, teacher.name
FROM student
INNER JOIN student ON students.Id = teachers.Id;