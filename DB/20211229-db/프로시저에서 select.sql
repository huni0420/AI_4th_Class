--select  procedure는 cursor를 반환해준다.
--그리고 이 cursor를 이용해서 결과를 출력
--cursor가 뭐냐면... sql 결과를 저장하는 메모리를 가리키는 포인터
create procedure person_select
(
    myname in varchar2,--매개변수
    o_cursor out sys_refcursor--커서를 반환
)
is
begin 
    open o_cursor
    for
        select num,name,phone_number from simple_address_book 
        where name = myname;
exception
    when others then
        dbms_output.put_line('sql error:'||sqlerrm);
    end person_select;
/


var o_cursor refcursor 
exec person_select('이동준',:o_cursor) /*o커서에 값저장*/ 
print o_cursor;



exec add_person(10,'이동준','101-3333-3341');
exec add_person(7,'이동준','010-2222-9999');