--view
--�������̺�
--���� �����ϴ� �� �ƴѵ�, ������ �������̰ų� ������ �������� �� select ������� �̸� ����� �α�

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