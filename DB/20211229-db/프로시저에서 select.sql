--select  procedure�� cursor�� ��ȯ���ش�.
--�׸��� �� cursor�� �̿��ؼ� ����� ���
--cursor�� ���ĸ�... sql ����� �����ϴ� �޸𸮸� ����Ű�� ������
create procedure person_select
(
    myname in varchar2,--�Ű�����
    o_cursor out sys_refcursor--Ŀ���� ��ȯ
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
exec person_select('�̵���',:o_cursor) /*oĿ���� ������*/ 
print o_cursor;



exec add_person(10,'�̵���','101-3333-3341');
exec add_person(7,'�̵���','010-2222-9999');