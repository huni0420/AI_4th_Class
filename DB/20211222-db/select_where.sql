select * from studenttable;
select * from studenttable where age>20;
select * from studenttable where age>20 and age<30;
select * from studenttable where name='���湮' or name='�ǵ���';
-- || <- �� ��ȣ�� mysql���� where������ ��������, oracle���� or Ű���常 ����
-- && <- mysql���� where������ ���̳� oracle�� and Ű���常 ����.
--select * from studenttable where name='���湮' || name='�ǵ���';
select * from studenttable where name='��'||'�湮'; --'��'||'�湮' = ���湮

select * from studenttable;

select * from studenttable where age=20;

select * from studenttable where age>=20 and age<30;

select * from studenttable order by age;-- ���� ��������

select * from studenttable order by age desc;-- ���� ��������

-- name�� �� �ձ��ڴ� ���̰�, �� �ڿ� ���� ���� �������
select * from studenttable where name like '��%'; -- ���� �Ǿ��� ����� ���

insert into studenttable values('���±�',40,'12345');

-- name�� �� �ޱ��ڰ� ���̰�, �� �տ� ���� ���� �������
select * from studenttable where name like '%��'; -- �̸����� ���� ����� ���

