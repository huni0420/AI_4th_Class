create /*or replace*/ PROCEDURE update_person
(
    mynum in int,--이름을 바꿀 학생의 번호
    changeName in varchar2 -- 내가 실제로 적용할 이름
)
is
    tempvar varchar2(20) := '학생'; --tempvar 변수에 '학생'을 대입
begin
    tempvar := changeName || tempvar;--내가 바꿀이름+학생 ex)이동준학생
    update simple_address_book set name = tempvar
    where num = mynum;
end update_person;
/


exec update_person(2,'류경문 ');
SELECT * FROM simple_address_book;--권도균 -> 류경문 학생