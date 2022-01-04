create table usertbl2
(
  userid char(8) primary key,
  username varchar2(10) not null
);

insert into userTbl2 values('KHD', '��ȣ��');
insert into userTbl2 values('KJD', '������');
insert into userTbl2 values('KKJ', '�豹��');
insert into userTbl2 values('KYM', '��븸');
insert into userTbl2 values('LHJ', '������');
insert into userTbl2 values('LKK', '�̰��');
insert into userTbl2 values('NHS', '����');
insert into userTbl2 values('PSH', '�ڼ�ȫ');
insert into userTbl2 values('SDY', '�ŵ���');
insert into userTbl2 values('YJS', '���缮');

create sequence tblseq2 INCREMENT by 1 maxvalue 100 minvalue 1 cycle nocache;


drop sequence tblseq2;
create sequence tblseq2 increment by 1 maxvalue 100 minvalue 1 cycle nocache;

create table buytbl2
(
  num int primary key,
  userid char(8),
  prodName varchar2(50) not null,
  price int not null,
  amout int not null
);
--�������� �߰�(=�ܷ�Ű�߰�)
--userid���� ����
alter table buytbl2 add CONSTRAINT fk_buy2 FOREIGN key (userid) REFERENCES usertbl2(userid);

INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '�ȭ', 30,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '��Ʈ��', 1000, 1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KYM', '�����', 200,  1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '�����', 200,  5);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', 'û����', 50,   3);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '�޸�', 80,  10);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KJD', 'å'   , 15,   5);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', 'å'   , 15,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', 'û����', 50,   1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '�ȭ', 30,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', 'å'   , 15,   1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '�ȭ', 30,   2);

select * from usertbl2;
select * from buytbl2;

alter table buytbl2 rename column amout to amount;
--1������
select username, prodname, price, amount, (price*amount) as �Ѱ��� 
from buytbl2 join usertbl2 on buytbl2.userid = usertbl2.userid;

--2������
--����� �ѱ��ž�(=group by)
--sum max count min -> group by�� ��︮�� �Լ�
select username , sum(price*amount) as �Ѱ��� from buytbl2 join usertbl2 
on buytbl2.userid = usertbl2.userid group by username;

--3������
--����� �ѱ��ž�(=group by �ʿ�)�� 1000���� �Ѵ� ���(having)
select username , sum(price*amount) as �Ѱ��� from buytbl2 join usertbl2 
on buytbl2.userid = usertbl2.userid group by username having sum(price*amount)>1000;

--4������ ���� �� �� �� ��





create table Univ_major
(
    code char(3) primary key,
    hakgwaname varchar2(20)
);
--�й��� ������ ������ ���� �����
create sequence univ_hakbeon_seq;

create table Univ_student
(   hakbeon int primary key,
    name varchar2(40),
    hakgwacode char(3),
    hakjeom number,
    foreign key(hakgwacode) references univ_major(code)
);

insert into univ_student values(univ_hakbeon_seq.nextval, 
'�̵���', '001', 1.2);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'���湮', '002', 3.5);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'�ǿ��', '001', 4.0);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'��ξ�', '003', 3.5);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'������', '003', 2.0);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'�ǵ���', '004', 3.3);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'�ǽ¿�', '005', 4.2);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'�ڸ�ȸ', '001', 4.3);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'�̿���', '001', 4.1);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'�㵿ȭ', '001', 4.15);

--insert into univ_student VALUES(1,'�̵���','001',1.2);
--insert into univ_student VALUES(2,'���湮','002',3.5);
--insert into univ_student VALUES(3,'�ǿ��','001',4);
--insert into univ_student VALUES(4,'��ξ�','003',3.5);
--insert into univ_student VALUES(5,'������','003',2);
--insert into univ_student VALUES(6,'�ǵ���','004',3.3);
--insert into univ_student VALUES(7,'�ǽ¿�','005',4.2);
--insert into univ_student VALUES(8,'�ڸ�ȸ','001',4.3);
--insert into univ_student VALUES(9,'�̿���','001',4.1);
--insert into univ_student VALUES(10,'�㵿ȭ','001',4.15);


insert into univ_major VALUES('001','�Ƶ�������');
insert into univ_major VALUES('002','�İ�');
insert into univ_major VALUES('003','���ڰ���');
insert into univ_major VALUES('004','�ɸ���');
insert into univ_major VALUES('005','�������');

select * from univ_student;
select * from univ_major;

--1
select s.hakbeon, s.name, m.hakgwaname, hakjeom
from univ_student s join univ_major m on s.hakgwacode = m.code;

--select hakbeon, name, hakgwaname, hakjeom from univ_student join univ_major on univ_student.hakgwacode = univ_major.code;

--2
select m.hakgwaname, avg(hakjeom)
from univ_student s join univ_major m on s.hakgwacode = m.code;



--select hakgwaname, AVG(hakjeom) as �а�������� from univ_student join univ_major on univ_student.hakgwacode = univ_major.code group by hakgwaname;

--3





---------------------------------------------------------------------------------------------
/*
create table userTbl
(
    userid char(8) primary key,
    username char(10) not null unique,
    FOREIGN KEY (userid) REFERENCES usertbl (userid)
);

insert into usertbl values('KHD','��ȣ��');
insert into usertbl values('KJD','���絿');
insert into usertbl values('KKJ','�豹��');
insert into usertbl values('KYM','��븸');
insert into usertbl values('LHJ','������');
insert into usertbl values('LKK','�̰��');
insert into usertbl values('NHS','����');
insert into usertbl values('PSH','�ڼ�ȫ');
insert into usertbl values('SDY','�ŵ���');
insert into usertbl values('YJS','���缮');

select * from usertbl;

drop table usertbl;
-------------------------------------------------------------------------------------


create table buyTbl
(
    num int primary key,
    userid char(8),
    proname char(9) not null,
    price int not null,
    amount int not null,
    FOREIGN KEY (userid) REFERENCES usertbl (userid)
);

insert into buytbl values(1,'KHD','�ȭ',30,2);
insert into buytbl values(2,'KHD','��Ʈ��',1000,1);
insert into buytbl values(3,'KYM','�����',200,1);
insert into buytbl values(4,'PSH','�����',200,5);
insert into buytbl values(5,'KHD','û����',50,3);
insert into buytbl values(6,'PSH','�޸�',80,10);
insert into buytbl values(7,'KJD','å',15,5);
insert into buytbl values(8,'LHJ','å',15,2);
insert into buytbl values(9,'LHJ','û����',50,1);
insert into buytbl values(10,'PSH','�ȭ',30,2);
insert into buytbl values(11,'LHJ','å',15,1);
insert into buytbl values(12,'PSH','�ȭ',30,2);

select * from buytbl;

drop table buytbl;
-----------------------------------------------------------------------------------------
--ALTER TABLE buytbl ADD FOREIGN KEY (userid) REFERENCES usertbl (userid);

select usertbl.username ����ڸ�, proname ��ǰ��, price ����, amount ����, price*amount �հ�
from buytbl
join usertbl on buytbl.userid = usertbl.userid;
*/
