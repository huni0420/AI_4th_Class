create table samsung
(
    id int primary key,
    name VARCHAR(30),
    boss_id int
);
delete from samsung;
insert into samsung values(1,'�̰���',1);
insert into samsung values(2,'ȫ����',2);
insert into samsung values(3,'�̺���',1);
insert into samsung values(4,'�����',1);
insert into samsung values(5,'�Ŷ�ȣ��',3);
insert into samsung values(6,'�Ｚ����',4);
insert into samsung values(7,'�����Ｚ',4);
insert into samsung values(8,'�Ｚ���̿���',4);
select * from samsung;
s
select aa.name boss, bb.name name from smasung aa join samsung bb on aa.id=bb.boss_id;