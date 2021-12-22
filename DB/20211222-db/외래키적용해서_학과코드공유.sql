select * from student;
select * from hakgwa;
insert into hakgwa values('001','컴공');
insert into hakgwa values('002','전자공학');
insert into hakgwa values('003','심리학');
insert into hakgwa values('004','아동가족학');
insert into hakgwa values('005','경제통상');
insert into hakgwa (hakgwa,hakgwacode) values('도박학과','777');
insert into hakgwa (hakgwacode,hakgwa) values('666','연금학과');

--더미(아무것도 검색안됨)
select * from dual;
--바이트 크기 체크
select lengthb('장') from dual;
select lengthb('a') from dual;
select lengthb('1') from dual;
select lengthb('ㅁ') from dual;
--글자 길이 체크
select length('장') from dual;

insert into student values('12345','류경문','001');
insert into student values('22222','제임스본드','007');
--무결성 제약조건(C##SCOTT.STUDENT_FK1)이 위배되었습니다- 부모 키가 없습니다

insert into hakgwa values('007','카지노로얄과');--이걸추가해서 부모키생성

select * from student;

insert into student values('33333','권용규','002');
insert into student values('88888','이동준','001');
insert into student values('43212','이주민','001');

select * from student,hakgwa; -- 아무 의미없는 코드!!!
select * from student s,hakgwa h where s.hakgwacode=h.hakgwacode;
select hakbeon, s.name,h.name from student s, hakgwa h  where s.hakgwacode = h.hakgwacode;

--위의 코드랑 똑같다. 위의 코드는 student는 s로 치환하고, hakgwa는 h로 치환한게 전부다.
select * from student, hakgwa where student.hakgwacode = hakgwa.hakgwacode;
select hakbeon, student.name, hakgwa.name from student, hakgwa where student.hakgwacode = hakgwa.hakgwacode;