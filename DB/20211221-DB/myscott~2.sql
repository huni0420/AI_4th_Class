create table cloth
(
    pnum varchar2(20) primary key,
    color varchar2(20),
    type varchar2(20)
);

select * from cloth;
insert into cloth values('1','����','�ĵ�Ƽ');
insert into cloth values('2','�Ķ�','�纹');
delete from cloth where pnum='2';
update cloth set color='��ũ' where type='�ĵ�Ƽ';
select * from cloth;
select color,type from cloth;
select color,type from cloth where pnum='1';