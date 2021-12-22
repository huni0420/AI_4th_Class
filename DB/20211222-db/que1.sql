--1
create table studenttable
(
    name varchar2(20),
    age number(20),
    id number(20) primary key
);
select * from studenttable;

insert into studenttable values('±Ç¿ë±Ô', 15, 20903);
insert into studenttable values('·ù°æ¹®', 25, 19703);
insert into studenttable values('±Ç½Â¿¬', 35, 18809);
insert into studenttable values('±è¹Î¾Æ', 20, 22103);
insert into studenttable values('±Çµµ±Õ', 22, 21809);

--2
create table teachertable
(
    name varchar2(20),
    age number,
    sabeon number primary key
);

insert into teachertable values('ÀÌ³ª°â',20,2021090101);
insert into teachertable values('ÀÌµ¿ÁØ',30,2021080105);
insert into teachertable values('¹ÚÈ£¹ü',40,2021030301);
insert into teachertable values('¹Ú¸íÈ¸',25,2020100111);
insert into teachertable values('±èÈ«±Ù',30,1999030207);

--3
delete from studenttable where name='±Ç¿ë±Ô';

--4
select 'ÀÌ³ª°â' from teachertable;

--5
update teachertable set age=25 where name='¹ÚÈ£¹ü';

--6
update teachertable set sabeon=2011080105 where name='ÀÌÁÖ¹Î';


--7
select * from studenttable;
select * from teachertable;

commit;dh