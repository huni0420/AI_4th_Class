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

select * from employee order by age; --오름
select * from employee order by age desc;--내림

select sabeon,age from employee;

select sabeon as "사원번호", age as "나이" from employee;
--% : 0글자 이상
select * from employee where name like '%a%';
commit;
show autocommit; --현재 commit이 자동으로 되는지 확인해보고
set autocommit on; -- off라면 해당 코드 작성하기