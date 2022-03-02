#테이블 생성
CREATE TABLE MP_BOARD(
    BNO INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    TITLE VARCHAR(100) NOT NULL,
    CONTENT VARCHAR(2000) NOT NULL,
    WRITER VARCHAR(100) NOT NULL,
    REGDATE TIMESTAMP DEFAULT NOW()
);

drop table mp_board;

SELECT * FROM mp_board;

#테이블 값 삽입
INSERT INTO  MP_BOARD(TITLE, CONTENT, WRITER) VALUES('이제그만', '내용입니다', '사용자');
INSERT INTO  MP_BOARD(TITLE, CONTENT, WRITER) VALUES('데이터를넣어보자', '그렇습니다', 'ABCD');
INSERT INTO  MP_BOARD(TITLE, CONTENT, WRITER) VALUES('데이터가 들어갔네요', 'aaa', 'lsh');


#더미데이터 만들기
SELECT  BNO, 
        TITLE, 
		CONTENT,
        WRITER, 
	    regdatemp_board
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

#리플테이블 생성
create table mp_reply (
	bno INT NOT NULL,
    rno INT  AUTO_INCREMENT not NULL,
    content varchar(1000) not null,
    writer varchar(50) not null,
    regdate TIMESTAMP DEFAULT NOW(),
    primary key(rno)
);

drop table mp_reply;

SELECT * FROM mp_reply;

#foreign키 만들기
alter table mp_reply add constraint mp_reply_bno foreign key(bno) references mp_board(bno);

insert into mp_reply(bno, rno, content, writer)
    VALUES(1, rno, '테스트댓글', '테스트 작성자');

#멤버테이블
create table MP_MEMBER(
    USERID VARCHAR(40) NOT NULL,
    USERPASS VARCHAR(100) NOT NULL,
    USERNAME VARCHAR(40) NOT NULL,
    REGDATE TIMESTAMP DEFAULT NOW(),
    PRIMARY KEY(USERID)
);

select * from MP_MEMBER;

DROP TABLE mp_member;

commit;
