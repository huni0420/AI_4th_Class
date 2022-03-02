--게시판 데이터 만들기
CREATE TABLE MP_BOARD(
    BNO NUMBER NOT NULL,
    TITLE VARCHAR2(100)     NOT NULL,
    CONTENT VARCHAR2(2000)  NOT NULL,
    WRITER VARCHAR2(100)    NOT NULL,
    REGDATE DATE            DEFAULT SYSDATE,
    PRIMARY KEY(BNO)
);

drop table MP_BOARD;

--게시판 시퀀스 만들기
CREATE SEQUENCE MP_BOARD_SEQ
START WITH 1
INCREMENT BY 1;

drop sequence mp_board_seq;

--게시판 테스트용 입력쿼리
INSERT INTO MP_BOARD(BNO, TITLE, CONTENT, WRITER)
     VALUES (MP_BOARD_SEQ.NEXTVAL, '이제그만', '내용입니다', '사용자');
INSERT INTO MP_BOARD(BNO, TITLE, CONTENT, WRITER)
     VALUES (MP_BOARD_SEQ.NEXTVAL, '데이터를넣어보자', '그렇습니다', 'ABCD');
INSERT INTO MP_BOARD(BNO, TITLE, CONTENT, WRITER)
     VALUES (MP_BOARD_SEQ.NEXTVAL, '데이터가 들어갔네요', 'aaa', 'lsh');

SELECT * FROM MP_BOARD;

COMMIT;

--더미용 데이터 작성
insert into mp_board(bno, title, content, writer)
select mp_board_seq.nextval, title, content, writer from mp_board;

commit;

--맨뒤에부터 데이터 10개 검색해보기
SELECT  BNO, 
        TITLE, 
		CONTENT,
        WRITER, 
	    regdate
 FROM ( 
        SELECT BNO, 
               TITLE, 
               CONTENT, 
               WRITER, 
               REGDATE, 
               ROW_NUMBER() OVER(ORDER BY BNO DESC) AS RNUM
         FROM MP_BOARD 
                       ) MP
WHERE RNUM BETWEEN 1 AND 10
ORDER BY BNO DESC;

--댓글 게시판 만들기
create table mp_reply (
    bno number not null,
    rno number not null,
    content varchar2(1000) not null,
    writer varchar2(50) not null,
    regdate date default sysdate,
    primary key(bno, rno)
);

drop table mp_reply;

--foreign키 만들기
alter table mp_reply add constraint mp_reply_bno foreign key(bno)
references mp_board(bno);

--댓글 게시판 시퀀스
create sequence mp_reply_seq START WITH 1 MINVALUE 0;

DROP SEQUENCE mp_reply_seq;

commit;

--게시판 테스트용 입력쿼리
insert into mp_reply(bno, rno, content, writer)
    values(418, mp_reply_seq.nextval, '테스트댓글', '테스트 작성자');

--게시판 테스트용 확인
select rno, content, writer, regdate
  from mp_reply
 where bno = 418;
 
 commit;
 
--회원가입 데이터 만들기
create table MP_MEMBER(
    USERID VARCHAR2(40) NOT NULL,
    USERPASS VARCHAR2(100) NOT NULL,
    USERNAME VARCHAR2(40) NOT NULL,
    REGDATE DATE DEFAULT SYSDATE,
    PRIMARY KEY(USERID)
);

commit;

select * from MP_MEMBER;