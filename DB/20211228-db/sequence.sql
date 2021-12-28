create sequence myseq start with 1 increment by 1 maxvalue 100 cycle nocache;

insert into simpletable values (myseq.nextval,'이동준');
insert into simpletable values (myseq.nextval,'권용규');
insert into simpletable values (myseq.nextval,'이원만');
select * from simpletable;

insert into myyimetable (column1) values(sequence1.nextval);
select * from mytimetaqble;