select * from book order by publisher;

select sum(price) 출판사별_출간책_총가격,publisher from book group by publisher;

select count(publisher) 총출판책, publisher from book group by publisher order by count(*) desc;

select sum(price) 총가격 from book;

select publisher from book group by publisher having count(*)>1;

select max(price) from book;

select * from book where price = (select max(price) from book);
select * from book where price = (select min(price) from book);