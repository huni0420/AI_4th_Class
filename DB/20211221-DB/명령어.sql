select * from cloth;
INSERT INTO "C##SCOTT"."CLOTH" (PNUM, TYPE, COLOR) VALUES ('2222', '전투복', '녹색');
insert into cloth values('1234','양복','검은색');
--삭제
delete from cloth where pnum='123';
--수정
update cloth set color='빨강색' where type='양복';
--후드티라는 옷 찾기

select * from cloth where type='후드티';

--후드티 옷의 색깔을 찾으시오.
select color from cloth where type='후드티';

