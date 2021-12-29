create or replace PROCEDURE delete_person
(
    mynum in int
)
is
begin
    delete from simple_address_book where num = mynum;
End delete_person;
/

exec delete_person(1);
select * from simple_address_book;