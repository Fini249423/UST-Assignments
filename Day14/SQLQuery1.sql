create table persons(personId int,firstname varchar(20),city varchar(20));
insert into persons values(102,'ammu','tvm');
insert into persons values(104,'sree','thrissur');
insert into persons values(101,'sam','palakad');
insert into persons values(103,'ambu','palayam');
insert into persons values(105,'ram','ernklm');
insert into persons values(107,'ravi','kochi');
insert into persons values(108,'rahul','vettucaud');

--select * from Persons where firstname like 'a%';
--drop table persons;

--select * from Persons where firstname like '_u%';

--select * from Persons order by pid desc;

--select * from Persons;

--select * from Persons where fname='manu' and city='kochi';

--select * from Persons where fname='manu' or city='kochi';

--select * from Persons order by city;

--select * from Persons order by city desc;

--select * from Persons order by city desc, fname asc;
--select * from Persons;































select*from persons
order by personId desc;