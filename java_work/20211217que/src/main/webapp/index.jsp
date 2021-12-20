<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>
<head>
    <title>JSP - Hello World</title>
<body>
<form action="hello-servlet" method="post">
    아이디 <input type="text" name="id"><br>
    비밀번호 <input type="password" name="pw"><br>
    비밀번호 확인 <input type="password" name="pwa"><br>
    <input type="radio" name="gender" value="남자">남자
    <input type="radio" name="gender" value="여자">여자<br>
    <input type="checkbox" name="hobby" value="농구">농구
    <input type="checkbox" name="hobby" value="축구">축구
    <input type="checkbox" name="hobby" value="등산">등산
    <input type="checkbox" name="hobby" value="수영">수영<br>
    <input type="checkbox" name="favorate" value="Java">Java
    <input type="checkbox" name="favorate" value="C">C
    <input type="checkbox" name="favorate" value="Python">Python<br>
    <input type="submit" value="전송">
</form>
</body>
</html>