--Create table CLIENT_MASTER (CLIENTNO varchar(6) Check(CLIENTNO LIKE 'c%') primary key, NAME varchar(20) NOT NULL,
--ADDRESS1 varchar(30),ADDRESS2 varchar(30), CITY varchar(15), PINCODE numeric (8), STATE varchar(15),BALDUE numeric (10,2));
--drop table client_master;
--drop table product_master;
--drop table salesman_master;
--drop table sales_order;
--drop table sales_order_details;
--Create table PRODUCT_MASTER( PRODUCTNO varchar(6) Check (PRODUCTNO LIKE 'p%') primary key,DESCRIPTION varchar(15) NOT NULL,
--PROFITPERC numeric(4,2) NOT NULL, UNITMEASURE varchar(10) NOT NULL, QTYONHAND numeric(8) NOT NULL,REORDERLVL numeric(8) NOT NULL,
--SELLPRICE numeric (8,2) NOT NULL ,CONSTRAINT CHK1 CHECK(SELLPRICE<>0),
--COSTPRICE numeric(8,2) NOT NULL,CONSTRAINT CHK2 CHECK(COSTPRICE<>0));

--create table SALESMAN_MASTER(SALESMANNO varchar(6) Check(SALESMANNO LIKE 'S%') primary key,SALESMANNAME varchar(20) NOT NULL,
--ADDRESS1 varchar(30)NOT NULL,ADDRESS2 varchar(30),CITY varchar(20),PINCODE numeric(8), STATE varchar(20), 
--SALAMT numeric(8,2) NOT NULL,CONSTRAINT CHK3 CHECK(SALAMT<>0),TGTTOGET numeric (6,2) NOT NULL,
--YTDSALES NUMERIC NOT NULL,REMARKS varchar(60));

Create table SALES_ORDER(ORDERNO varchar(6) check(ORDERNO LIKE 'O%') primary key,
CLIENTNO VARCHAR(6) ,FOREIGN KEY (CLIENTNO) REFERENCES CLIENT_MASTER (CLIENTNO) ,ORDERDATE date,
DELYADDR varchar(25),SALESMANNO varchar(6),FOREIGN KEY(SALESMANNO) REFERENCES SALESMAN_MASTER(SALESMANNO)
,DELYTYPE CHAR(1),CONSTRAINT CHK4 Check(DELYTYPE ='P'OR DELYTYPE='F'),
BILLEDYN CHAR(1),CONSTRAINT CHK5 Check(BILLEDYN ='Y'OR BILLEDYN='N')
,DELYDATE DATE,
ORDERSTATUS VARCHAR(10),
CONSTRAINT CHK6  CHECK(ORDERSTATUS ='BACKORDER'OR ORDERSTATUS='CANCELLED'OR ORDERSTATUS='IN PROCESS'OR ORDERSTATUS='FULFILLED'));

--SELECT * FROM CLIENT_MASTER;

--drop table SALES_ORDER;


--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)
--VALUES ('C00001', 'Ivan Bayross', 'Mumbai', 400054, 'Maharashtra', 15000);
--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)
--values('c00002','mary','lucknow',400055,'UP',12000);
--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)
--values('c00005','surya','Srilanka',400055,'UP',12000);
--INSERT INTO Client_Master (ClientNo, Name, City, PinCode, State, BalDue)
--values('c00006','sree','california',400055,'UP',12000);
--INSERT INTO Product_Master VALUES ('P00001', 'T-Shirts', 5, 'Piece', 200, 50, 350, 250); 
--INSERT INTO Product_Master VALUES ('P00008', 'T-Shirts', 5, '1.44drive', 200, 50, 350, 250); 
--INSERT INTO Product_Master VALUES ('P00002', 'T-Shirts', 6, 'Piece', 200, 50, 3500, 250);
--INSERT INTO Salesman_Master VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good'); 

INSERT INTO Sales_Order(OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus)
VALUES('O19001', '12-june-02', 'C00001', 'F', 'N', 'S00001', '20-july-02', 'IN PROCESS'); 
INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P00001', 4, 4, 525);

--1
--select name from client_master;
--2
--select * from client_master where city='mumbai';
--3
--select * from product_master where sellprice between 2000 and 5000;
--4
--select name,city,state from client_master where state<> 'Maharashtra';
--5
--select * from client_master where clientno='C00001' or clientno= 'c00002' ;
--6
--update product_master  set sellprice=1500.50 where unitmeasure='1.44drive';
--7
--delete from client_master where clientno='c00005';
--8
--select * from Client_master where city like'_a%';
--9
--select count(description) from product_master where (sellprice >=1500);
--10
--select qtyordered,qtydisp from sales_order_details;

--1
--ALTER TABLE CLIENT_MASTER ADD PRIMARY KEY(CLIENT_NO);
--2
--ALTER TABLE CLIENT_MASTER
--ADD PHONE_NO NUMERIC(10);
--3
--ALTER TABLE PRODUCT_MASTER ALTER COLUMN DESCRIPTION VARCHAR(15) NOT NULL;
--ALTER TABLE PRODUCT_MASTER ALTER COLUMN PROFITPERC NUMERIC(4,2) NOT NULL;
--ALTER TABLE PRODUCT_MASTER ALTER COLUMN SELLPRICE NUMERIC(8,2) NOT NULL;
--ALTER TABLE PRODUCT_MASTER ALTER COLUMN COSTPRICE NUMERIC(8,2) NOT NULL;
--4
--ALTER TABLE [CLIENT_MASTER]
--ALTER COLUMN [NAME] VARCHAR(60) 
--5
--ALTER TABLE CLIENT_MASTER
--DROP COLUMN PINCODE;
--SELECT * FROM  CLIENT_MASTER;
--select * from sales_order;



