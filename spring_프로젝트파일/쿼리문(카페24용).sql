#테이블 생성
CREATE TABLE MP_BOARD(
    BNO INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    TITLE VARCHAR(100) NOT NULL,
    CONTENT VARCHAR(2000) NOT NULL,
    WRITER VARCHAR(100) NOT NULL,
    REGDATE TIMESTAMP DEFAULT NOW()
);
SET @rownum:=0;

drop table MP_BOARD;

SELECT * FROM MP_BOARD;

#테이블 값 삽입
INSERT INTO  MP_BOARD(TITLE, CONTENT, WRITER) VALUES('이제그만', '내용입니다', '사용자');
INSERT INTO  MP_BOARD(TITLE, CONTENT, WRITER) VALUES('데이터를넣어보자', '그렇습니다', 'ABCD');
INSERT INTO  MP_BOARD(TITLE, CONTENT, WRITER) VALUES('데이터가 들어갔네요', 'aaa', 'lsh');


#데이터 10개씩 조회
SELECT  BNO, 
        TITLE, 
		CONTENT,
        WRITER, 
	    REGDATE MP_BOARD
 FROM ( 
        	SELECT BNO, 
               TITLE, 
               CONTENT, 
               WRITER, 
               REGDATE,
               @rownum:=@rownum+1 AS RNUM
         FROM MP_BOARD  , (SELECT @rownum:=0) TMP
               ORDER BY BNO DESC        ) MP
WHERE RNUM BETWEEN 1 AND 10
ORDER BY BNO DESC;


#리플테이블 생성
create table MP_REPLY (
	bno INT NOT NULL,
    rno INT  AUTO_INCREMENT not NULL,
    content varchar(1000) not null,
    writer varchar(50) not null,
    regdate TIMESTAMP DEFAULT NOW(),
    primary key(rno)
);

drop table mp_reply;

SELECT * FROM MP_REPLY;

#foreign키 만들기
alter table MP_REPLY add constraint mp_reply_bno foreign key(bno) references MP_BOARD(bno);

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

COMMIT;

SHOW VARIABLES LIKE 'version';
