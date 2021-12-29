--view
--가상테이블
--실제 존재하는 건 아닌데, 복잡한 쿼리문이거나 복잡한 쿼리문에 들어갈 select 결과물을 미리 만들어 두기

create or replace view mytestview as 
select * from orders;

select * from mytestview;

create view expensive_book as
select * from book where price>10000;

select * from expensive_book;

create or replace view myorderview as
select orderid, aa.name, book.bookname, saleprice 
from(select orderid, customer.name,saleprice,bookid from orders join customer on orders.custid = customer.custid) 
aa join book 
on aa.bookid = book.bookid 
order by orderid;

select * from myorderview;