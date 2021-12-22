

insert into studenttable values('이동준',23,'99911','전자공학');
insert into studenttable values('이제영',24,'22211','아동가족학');
--만약 이 학교에 심리학과랑 아동가족학과는 있고, 아동심리학이 없으면?

select * from studenttable;

alter table mystudent rename to mystudenta; -- 테이블이름 변경