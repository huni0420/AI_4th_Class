create /*or replace*/ PROCEDURE update_person
(
    mynum in int,--�̸��� �ٲ� �л��� ��ȣ
    changeName in varchar2 -- ���� ������ ������ �̸�
)
is
    tempvar varchar2(20) := '�л�'; --tempvar ������ '�л�'�� ����
begin
    tempvar := changeName || tempvar;--���� �ٲ��̸�+�л� ex)�̵����л�
    update simple_address_book set name = tempvar
    where num = mynum;
end update_person;
/


exec update_person(2,'���湮 ');
SELECT * FROM simple_address_book;--�ǵ��� -> ���湮 �л�