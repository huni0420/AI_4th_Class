create table mtotal(
    total number,
    time TIMESTAMP primary key
);
drop table mtotal;
insert into mtotal values(12344,'2022-03-18');
select * from mtotal;

update mtotal set total = total+80000 where time = '2022-02-18';

select * from menu;
delete from menu where tablenum = 1;

select total from mtotal where time = '20220318';

commit;