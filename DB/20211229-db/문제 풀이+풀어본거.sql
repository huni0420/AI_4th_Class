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
