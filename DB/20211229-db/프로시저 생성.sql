--함수,트리거,프로시저
--셋 다 만드는 방법은 매우 유사
--특히 함수랑 프로시저는 만드는 방법이 거의 똑같다
--PL/SQL 즉 조건문이나 반복문이 있음

--프로시저 : 미리 만들어둔 코드를 함수호출하듯이 쓰는 것
--함수 : 프로시저의 실행단위. 즉 프로시저는 여러개의 함수들의 모음이라고도 볼 수 있다

--통상적으로 이 둘의 차이를 어떻게 보냐면...
--프로시저는 반환값이 없는 함수, 함수는 반환값이 있다라고 봄...
--이건 완벽한 정의는 아님. 왜나면 프로시저도 반환값이 있음.

--트리거 : 어떤 특정한 상황이 되었을 때 실행되는 프로시저

--프로시저를 통한 insert, update, delete, select
select * from simple_address_book;

create or replace procedure add_person
(
    mynum in int,
    myname varchar2,
    mypn varchar2
)
is
begin
    insert into simple_address_book values(mynum,myname,mypn);
end;
/
--프로시저를 컴파일하고나서, 테스트하고 싶으면 반드시 END뒤에 /를 하나 추가해야함 아니면 그냥 다른 sql파일에서 작업해도됨

--select * from simple_address_book;