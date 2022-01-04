create table usertbl2
(
  userid char(8) primary key,
  username varchar2(10) not null
);

insert into userTbl2 values('KHD', '강호동');
insert into userTbl2 values('KJD', '김제동');
insert into userTbl2 values('KKJ', '김국진');
insert into userTbl2 values('KYM', '김용만');
insert into userTbl2 values('LHJ', '이휘재');
insert into userTbl2 values('LKK', '이경규');
insert into userTbl2 values('NHS', '남희석');
insert into userTbl2 values('PSH', '박수홍');
insert into userTbl2 values('SDY', '신동엽');
insert into userTbl2 values('YJS', '유재석');

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
--제약조건 추가(=외래키추가)
--userid간의 연결
alter table buytbl2 add CONSTRAINT fk_buy2 FOREIGN key (userid) REFERENCES usertbl2(userid);

INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '운동화', 30,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '노트북', 1000, 1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KYM', '모니터', 200,  1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '모니터', 200,  5);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KHD', '청바지', 50,   3);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '메모리', 80,  10);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'KJD', '책'   , 15,   5);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', '책'   , 15,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', '청바지', 50,   1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '운동화', 30,   2);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'LHJ', '책'   , 15,   1);
INSERT INTO buyTbl2 VALUES(tblseq2.nextval, 'PSH', '운동화', 30,   2);

select * from usertbl2;
select * from buytbl2;

alter table buytbl2 rename column amout to amount;
--1번문제
select username, prodname, price, amount, (price*amount) as 총가격 
from buytbl2 join usertbl2 on buytbl2.userid = usertbl2.userid;

--2번문제
--사람별 총구매액(=group by)
--sum max count min -> group by랑 어울리는 함수
select username , sum(price*amount) as 총가격 from buytbl2 join usertbl2 
on buytbl2.userid = usertbl2.userid group by username;

--3번문제
--사람별 총구매액(=group by 필요)이 1000원이 넘는 경우(having)
select username , sum(price*amount) as 총가격 from buytbl2 join usertbl2 
on buytbl2.userid = usertbl2.userid group by username having sum(price*amount)>1000;

--4번문제 정답 뷰 안 쓴 거





create table Univ_major
(
    code char(3) primary key,
    hakgwaname varchar2(20)
);
--학번을 저장할 시퀀스 먼저 만들기
create sequence univ_hakbeon_seq;

create table Univ_student
(   hakbeon int primary key,
    name varchar2(40),
    hakgwacode char(3),
    hakjeom number,
    foreign key(hakgwacode) references univ_major(code)
);

insert into univ_student values(univ_hakbeon_seq.nextval, 
'이동준', '001', 1.2);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'류경문', '002', 3.5);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'권용규', '001', 4.0);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'김민아', '003', 3.5);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'이진주', '003', 2.0);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'권도균', '004', 3.3);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'권승연', '005', 4.2);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'박명회', '001', 4.3);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'이원만', '001', 4.1);
insert into univ_student values(univ_hakbeon_seq.nextval, 
'허동화', '001', 4.15);

--insert into univ_student VALUES(1,'이동준','001',1.2);
--insert into univ_student VALUES(2,'류경문','002',3.5);
--insert into univ_student VALUES(3,'권용규','001',4);
--insert into univ_student VALUES(4,'김민아','003',3.5);
--insert into univ_student VALUES(5,'이진주','003',2);
--insert into univ_student VALUES(6,'권도균','004',3.3);
--insert into univ_student VALUES(7,'권승연','005',4.2);
--insert into univ_student VALUES(8,'박명회','001',4.3);
--insert into univ_student VALUES(9,'이원만','001',4.1);
--insert into univ_student VALUES(10,'허동화','001',4.15);


insert into univ_major VALUES('001','아동가족학');
insert into univ_major VALUES('002','컴공');
insert into univ_major VALUES('003','전자공학');
insert into univ_major VALUES('004','심리학');
insert into univ_major VALUES('005','전기공학');

select * from univ_student;
select * from univ_major;

--1
select s.hakbeon, s.name, m.hakgwaname, hakjeom
from univ_student s join univ_major m on s.hakgwacode = m.code;

--select hakbeon, name, hakgwaname, hakjeom from univ_student join univ_major on univ_student.hakgwacode = univ_major.code;

--2
select m.hakgwaname, avg(hakjeom)
from univ_student s join univ_major m on s.hakgwacode = m.code;



--select hakgwaname, AVG(hakjeom) as 학과평균학점 from univ_student join univ_major on univ_student.hakgwacode = univ_major.code group by hakgwaname;

--3





---------------------------------------------------------------------------------------------
/*
create table userTbl
(
    userid char(8) primary key,
    username char(10) not null unique,
    FOREIGN KEY (userid) REFERENCES usertbl (userid)
);

insert into usertbl values('KHD','강호동');
insert into usertbl values('KJD','김재동');
insert into usertbl values('KKJ','김국진');
insert into usertbl values('KYM','김용만');
insert into usertbl values('LHJ','이휘재');
insert into usertbl values('LKK','이경규');
insert into usertbl values('NHS','남희석');
insert into usertbl values('PSH','박수홍');
insert into usertbl values('SDY','신동엽');
insert into usertbl values('YJS','유재석');

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

insert into buytbl values(1,'KHD','운동화',30,2);
insert into buytbl values(2,'KHD','노트북',1000,1);
insert into buytbl values(3,'KYM','모니터',200,1);
insert into buytbl values(4,'PSH','모니터',200,5);
insert into buytbl values(5,'KHD','청바지',50,3);
insert into buytbl values(6,'PSH','메모리',80,10);
insert into buytbl values(7,'KJD','책',15,5);
insert into buytbl values(8,'LHJ','책',15,2);
insert into buytbl values(9,'LHJ','청바지',50,1);
insert into buytbl values(10,'PSH','운동화',30,2);
insert into buytbl values(11,'LHJ','책',15,1);
insert into buytbl values(12,'PSH','운동화',30,2);

select * from buytbl;

drop table buytbl;
-----------------------------------------------------------------------------------------
--ALTER TABLE buytbl ADD FOREIGN KEY (userid) REFERENCES usertbl (userid);

select usertbl.username 사용자명, proname 제품명, price 가격, amount 수량, price*amount 합계
from buytbl
join usertbl on buytbl.userid = usertbl.userid;
*/
