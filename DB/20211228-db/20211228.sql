--1
create table employee  
(
    sabeon int primary key,
    name VARCHAR(20),
    age int,
    jikgueb VARCHAR(20)
);

SELECT * FROM employee;

--2
insert into employee values(2009038033, 'lee', 33, 'senior');
insert into employee values(2021000111, 'park', 19, 'manager');
insert into employee values(2021000112, 'kim', 77,'beginner');
insert into employee values(2021000113, 'choi', 55, 'senior');
insert into employee values(2021000114, 'Jang', 47, 'manager');
--3
update employee set jikgueb = 'beginner' where age<30;
--4
update employee set jikgueb = 'manager' where age>50;
--5
delete from employee where age>70;
--6
SELECT * FROM employee;
--7
select * from employee where jikgueb = 'senior';

select * from employee order by age; --����
select * from employee order by age desc;--����

select sabeon,age from employee;

select sabeon as "�����ȣ", age as "����" from employee;
--% : 0���� �̻�
select * from employee where name like '%a%';
commit;
show autocommit; --���� commit�� �ڵ����� �Ǵ��� Ȯ���غ���
set autocommit on; -- off��� �ش� �ڵ� �ۼ��ϱ�