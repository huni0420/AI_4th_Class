select * from student;
select * from hakgwa;
insert into hakgwa values('001','�İ�');
insert into hakgwa values('002','���ڰ���');
insert into hakgwa values('003','�ɸ���');
insert into hakgwa values('004','�Ƶ�������');
insert into hakgwa values('005','�������');
insert into hakgwa (hakgwa,hakgwacode) values('�����а�','777');
insert into hakgwa (hakgwacode,hakgwa) values('666','�����а�');

--����(�ƹ��͵� �˻��ȵ�)
select * from dual;
--����Ʈ ũ�� üũ
select lengthb('��') from dual;
select lengthb('a') from dual;
select lengthb('1') from dual;
select lengthb('��') from dual;
--���� ���� üũ
select length('��') from dual;

insert into student values('12345','���湮','001');
insert into student values('22222','���ӽ�����','007');
--���Ἲ ��������(C##SCOTT.STUDENT_FK1)�� ����Ǿ����ϴ�- �θ� Ű�� �����ϴ�

insert into hakgwa values('007','ī����ξ��');--�̰��߰��ؼ� �θ�Ű����

select * from student;

insert into student values('33333','�ǿ��','002');
insert into student values('88888','�̵���','001');
insert into student values('43212','���ֹ�','001');

select * from student,hakgwa; -- �ƹ� �ǹ̾��� �ڵ�!!!
select * from student s,hakgwa h where s.hakgwacode=h.hakgwacode;
select hakbeon, s.name,h.name from student s, hakgwa h  where s.hakgwacode = h.hakgwacode;

--���� �ڵ�� �Ȱ���. ���� �ڵ�� student�� s�� ġȯ�ϰ�, hakgwa�� h�� ġȯ�Ѱ� ���δ�.
select * from student, hakgwa where student.hakgwacode = hakgwa.hakgwacode;
select hakbeon, student.name, hakgwa.name from student, hakgwa where student.hakgwacode = hakgwa.hakgwacode;