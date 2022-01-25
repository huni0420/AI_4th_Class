create table parking
(
    carname varchar(40),
    time varchar(40) primary key,
    status varchar(10)
);
drop table parking;

select * from parking;

insert into paking values('1234','2022-01-26 01:09','입고');

--ALTER table parking modify(cash number,credit number,discount number);
--select * from parking;
--insert into parking values('aaa123','입고',10000,0,0,sysdate);

--select to_char(time,'YYYY-DD-MM HH24:MI') from parking where carname = 'aaa123';