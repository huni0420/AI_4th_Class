select * from cloth;
INSERT INTO "C##SCOTT"."CLOTH" (PNUM, TYPE, COLOR) VALUES ('2222', '������', '���');
insert into cloth values('1234','�纹','������');
--����
delete from cloth where pnum='123';
--����
update cloth set color='������' where type='�纹';
--�ĵ�Ƽ��� �� ã��

select * from cloth where type='�ĵ�Ƽ';

--�ĵ�Ƽ ���� ������ ã���ÿ�.
select color from cloth where type='�ĵ�Ƽ';

