create table book
(
    bookid int primary key,
    bookname varchar2(40),
    publisher varchar2(40),
    price int
);
create table Customer
(
    custid int primary key,
    name varchar2(40),
    address varchar2(50),
    phone varchar2(20)
);

insert into book values(1,'축구의 역사','굿스포츠',7000);
insert into book values(2,'축구 아는 여자','나무수',13000);
insert into book values(3,'축구의 이해','대한미디어',22000);
insert into book values(4,'골프 바이블','대한미디어',35000);
insert into book values(5,'피겨 교본','굿스포츠',8000);
insert into book values(6,'역도 단계별 기술','굿스포츠',6000);
insert into book values(7,'야구의 추억','이상미디어',20000);
insert into book values(8,'야구를 부탁해','이상미디어',13000);
insert into book values(9,'올림픽 이야기','삼성당',7500);
insert into book values(10,'Olympic champions','pearson',13000);

select * from book;

insert into customer values(1,'박지성','영국 멘체스타','000-5000-0001');
insert into customer values(2,'김연아','대한민국 서울','000-6000-0001');
insert into customer values(3,'장미란','대한민국 강원도','000-7000-0001');
insert into customer values(4,'추신수','미국 클리블랜드','000-8000-0001');
insert into customer values(5,'박세리','대한민국 대전',null);

select * from customer;

create table Orders
(
    orderid int primary key,
    custid int,
    bookid int,
    saleprice int,
    orderdate date default sysdate,
    foreign key(custid) REFERENCES customer(custid), 
    foreign key(bookid) REFERENCES book(bookid)
);

insert into Orders(orderid,custid,bookid) values(1,1,1);
SELECT * from orders;

insert into Orders(orderid,custid,bookid) values(2,1,3);
insert into Orders(orderid,custid,bookid) values(3,2,5);
insert into Orders(orderid,custid,bookid) values(4,3,6);
insert into Orders(orderid,custid,bookid) values(5,4,7);
insert into Orders(orderid,custid,bookid) values(6,1,2);
insert into Orders(orderid,custid,bookid) values(7,4,8);
insert into Orders(orderid,custid,bookid) values(8,3,10);
insert into Orders(orderid,custid,bookid) values(9,2,10);
insert into Orders(orderid,custid,bookid) values(10,1,8);

select * from Orders;

update Orders set saleprice = (select price from book where bookid=1)where bookid=1;
update Orders set saleprice = (select price from book where bookid=2)where bookid=2;
update Orders set saleprice = (select price from book where bookid=3)where bookid=3;
update Orders set saleprice = (select price from book where bookid=4)where bookid=4;
update Orders set saleprice = (select price from book where bookid=5)where bookid=5;
update Orders set saleprice = (select price from book where bookid=6)where bookid=6;
update Orders set saleprice = (select price from book where bookid=7)where bookid=7;
update Orders set saleprice = (select price from book where bookid=8)where bookid=8;
update Orders set saleprice = (select price from book where bookid=9)where bookid=9;
update Orders set saleprice = (select price from book where bookid=10)where bookid=10;