select * from book order by publisher;

select sum(price) ���ǻ纰_�Ⱓå_�Ѱ���,publisher from book group by publisher;

select count(publisher) ������å, publisher from book group by publisher order by count(*) desc;

select sum(price) �Ѱ��� from book;

select publisher from book group by publisher having count(*)>1;

select max(price) from book;

select * from book where price = (select max(price) from book);
select * from book where price = (select min(price) from book);