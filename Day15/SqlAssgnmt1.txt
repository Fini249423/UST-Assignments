------ 1 - 3 ----



CREATE TABLE REGIONS(REGION_ID INTEGER PRIMARY KEY,REGION_NAME VARCHAR(25));

CREATE TABLE COUNTRIES(COUNTRY_ID INTEGER PRIMARY KEY,COUNTRY_NAME VARCHAR(25), REGION_ID INTEGER,

	FOREIGN KEY(REGION_ID) REFERENCES REGIONS(REGION_ID));

CREATE TABLE JOBS(JOB_ID INTEGER PRIMARY KEY, JOB_TITLE VARCHAR(25),

	MIN_SALARY MONEY ,MAX_SALARY MONEY);

CREATE TABLE LOCATIONS (LOCATION_ID INTEGER PRIMARY KEY, STREET_ADDRESS VARCHAR(35),

	POSTAL_CODE INT, CITY VARCHAR(25), STATE_PROVINCE VARCHAR(20), COUNTRY_ID INTEGER,

	FOREIGN KEY(COUNTRY_ID) REFERENCES COUNTRIES(COUNTRY_ID));

CREATE TABLE DEPARTMENTS(DEPARTMENT_ID INTEGER PRIMARY KEY, DEPARTMENT_NAME VARCHAR(25),

	MANAGER_ID INTEGER, LOCATION_ID INTEGER, FOREIGN KEY(LOCATION_ID) REFERENCES LOCATIONS(LOCATION_ID));

CREATE TABLE EMPLOYEES(EMPLOYEE_ID INTEGER PRIMARY KEY, FIRST_NAME VARCHAR(25),

	LAST_NAME VARCHAR(25), EMAIL VARCHAR(25), PHONE_NUMBER NUMERIC, HIRE_DATE DATE,

	SALARY MONEY, COMMISSION_PCT MONEY, MANAGER_ID INTEGER,

	JOB_ID INTEGER, DEPARTMENT_ID INTEGER,

	FOREIGN KEY(JOB_ID) REFERENCES JOBS(JOB_ID),

	FOREIGN KEY(DEPARTMENT_ID) REFERENCES DEPARTMENTS(DEPARTMENT_ID));

CREATE TABLE JOB_HISTORY(EMPLOYEE_ID INTEGER, START_DATE DATE, END_DATE DATE, JOB_ID INTEGER,

 DEPARTMENT_ID INTEGER, FOREIGN KEY(JOB_ID) REFERENCES JOBS(JOB_ID),

	FOREIGN KEY(EMPLOYEE_ID) REFERENCES EMPLOYEES(EMPLOYEE_ID),

	FOREIGN KEY(DEPARTMENT_ID) REFERENCES DEPARTMENTS(DEPARTMENT_ID));

--INSERT INTO REGIONS VALUES (102,'Antartica');   *****

select * from regions;

--INSERT INTO COUNTRIES VALUES(202,'China',102);    ****

select * from countries;

--INSERT INTO LOCATIONS VALUES(302,'Vettucaud',685582,'TVM','Kerala',202);     *****

select * from locations;

--INSERT INTO JOBS VALUES(402,'HR',40000,45000);   *****

--INSERT INTO DEPARTMENTS VALUES(602,'Sales',502,302);   ****

--INSERT INTO DEPARTMENTS VALUES(90,'Accounts',502,302);     *****

--select * from DEPARTMENTS;

--INSERT INTO EMPLOYEES VALUES(702,'Ram','Kumar','ram@gmail.com',854467,'2023-05-02',30000,5000,502,402,602);   *****

--INSERT INTO EMPLOYEES VALUES(703,'Ajith','Naran','ajith@gmail.com',887634,'2021-07-11',55000,6000,502,402,90);   *****

--select * from employees;

--INSERT INTO JOB_HISTORY VALUES(702,'2023-05-02','2043-05-02',402,602);  ****

----------------------

---- 4 ----

select first_name,salary,12*(salary+100) from Employees;

----- 5 -----

 update Employees set phone_number='2'+REPLICATE('0',7-len('2'+phone_number))+phone_number

 where len(phone_number)=5;

select * from employees;

---- 6 ----

DELETE employee_id, salary, job_id FROM employees WHERE dept_id = 90;

 delete from Employees where department_id=90;

---- 7 -----

select distinct(department_id) from Employees where last_name='Smith';

---- 8 -----

-- SELECT empname,hire_date HIREDATE, salary FROM EMPLOYEES ORDER BY hire_date;

 select first_name,last_name,hire_date,salary from Employees order by hire_date asc;

---- 9 -----

CREATE TABLE STUDENT_GRADES(STUDENT_ID NUMERIC(12) PRIMARY KEY,SEMESTER_END DATE, GPA NUMERIC(4,3));

INSERT INTO STUDENT_GRADES VALUES(1,'03-05-2023',8.5);

INSERT INTO STUDENT_GRADES VALUES(2,'03-05-2022',9.11);

SELECT * FROM STUDENT_GRADES;

 select student_id,semester_end,gpa from student_grades order by semester_end,gpa desc;

 ---- 10 -----

 select first_name from Employees where department_id not in(select department_id from departments);

----- 11 -----

CREATE TABLE CUSTOMERS(CUSTOMER_ID NUMERIC(4) PRIMARY KEY, CUSTOMER_NAME VARCHAR(100) NOT NULL,

 CUSTOMER_ADDRESS VARCHAR(150), CUSTOMER_PHONE VARCHAR(20));

--INSERT INTO CUSTOMERS VALUES(1222,'Adi',' Narayan','8745673214');   ******

select * from CUSTOMERS;

select concat('Dear Customer ',customer_name,' .') from customers;

---- 12 ----

 CREATE TABLE EMP(ID INTEGER PRIMARY KEY, NAME VARCHAR(20),SAL DECIMAL(10,2), COMM_PCT DECIMAL(5,2),

 PF DECIMAL(10,2), HRA DECIMAL(10,2), TEARN DECIMAL(10,2), TDED DECIMAL(10,2), NET DECIMAL(10,2));

 insert into Emp(id,name,sal,comm_pct,pf) values

 (110,'Shilpa',60000,0.07,5000),

 (210,'Abhi',75000,0.13,6000),

 (310,'Ben',90000,0.16,7500);

 update Emp set hra=0.12*sal,  tded=0.04*sal;

 update Emp set tearn=sal+hra;

 UPDATE EMP SET net=(tearn-tded);

 select * from emp;































































