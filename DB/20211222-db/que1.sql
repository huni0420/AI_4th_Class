--1
create table studenttable
(
    name varchar2(20),
    age number(20),
    id number(20) primary key
);
select * from studenttable;

insert into studenttable values('�ǿ��', 15, 20903);
insert into studenttable values('���湮', 25, 19703);
insert into studenttable values('�ǽ¿�', 35, 18809);
insert into studenttable values('��ξ�', 20, 22103);
insert into studenttable values('�ǵ���', 22, 21809);

--2
create table teachertable
(
    name varchar2(20),
    age number,
    sabeon number primary key
);

insert into teachertable values('�̳���',20,2021090101);
insert into teachertable values('�̵���',30,2021080105);
insert into teachertable values('��ȣ��',40,2021030301);
insert into teachertable values('�ڸ�ȸ',25,2020100111);
insert into teachertable values('��ȫ��',30,1999030207);

--3
delete from studenttable where name='�ǿ��';

--4
select '�̳���' from teachertable;

--5
update teachertable set age=25 where name='��ȣ��';

--6
update teachertable set sabeon=2011080105 where name='���ֹ�';


--7
select * from studenttable;
select * from teachertable;

commit;dh