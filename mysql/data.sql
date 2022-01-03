CREATE TABLE `board` (
   `idx` INT NULL primary key AUTO_INCREMENT,
   `name` VARCHAR(50) NULL DEFAULT NULL,
   `title` VARCHAR(50) NULL DEFAULT NULL,
   `content` VARCHAR(50) NULL DEFAULT NULL,
   `wdate` DATETIME
)
COMMENT='게시판'
COLLATE='utf8_general_ci'
;
INSERT INTO board 
(name, title,content,wdate) 
VALUES 
('aaa', ' 제목','제목',NOW());

SELECT  FROM_BASE64('1234') AS base64encodevalue;

DELETE FROM board WHERE idx IN (1,2);

CREATE TABLE `user` (
	`id` VARCHAR(50) NOT NULL PRIMARY KEY,
	`password` VARCHAR(50) NULL DEFAULT NULL
);
INSERT INTO user VALUES ('aa','123');
SELECT * FROM user;