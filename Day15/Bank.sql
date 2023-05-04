--create table BankTB(ACNO integer primary key,AcHolderName varchar(20),Balance float,RefACNO integer);
--insert into BankTB values(101,'Ram',22000,102);
--insert into BankTB values(102,'Riya',24000,101);
--select * from BankTB;

select a.ACNO as 'ACNO',a.AcHolderName as [Account Holder Name],--self join and using aliases taking the name of referrer
a.Balance  as 'Balance',a.RefACNO as [Ref Acno],r.AcHolderName as [Name of Referrer]
from BankTB a left join BankTB r
on a.RefACNO=r.ACNO;
--drop table BankTB;
