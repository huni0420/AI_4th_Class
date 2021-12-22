select * from studenttable;
select * from studenttable where age>20;
select * from studenttable where age>20 and age<30;
select * from studenttable where name='류경문' or name='권도균';
-- || <- 이 기호가 mysql에선 where에서도 쓰이지만, oracle에선 or 키워드만 쓰임
-- && <- mysql에선 where에서도 쓰이나 oracle은 and 키워드만 쓴다.
--select * from studenttable where name='류경문' || name='권도균';
select * from studenttable where name='류'||'경문'; --'류'||'경문' = 류경문

select * from studenttable;

select * from studenttable where age=20;

select * from studenttable where age>=20 and age<30;

select * from studenttable order by age;-- 나이 오름차순

select * from studenttable order by age desc;-- 나이 내림차순

-- name의 맨 앞글자는 권이고, 그 뒤엔 뭐가 들어가도 상관없음
select * from studenttable where name like '권%'; -- 성이 권씨인 사람들 출력

insert into studenttable values('김태균',40,'12345');

-- name의 맨 뒷글자가 권이고, 그 앞엔 뭐가 들어가도 상관없음
select * from studenttable where name like '%균'; -- 이름끝에 권인 사람들 출력

