<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2022-01-03
  Time: 오전 9:29
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <%@ include file="boot.jsp"%>
    <title>JSP 로그인 페이지</title>
</head>
<body>
<ul class="nav">
    <li class="nav-item">
        <a class="nav-link active" aria-current="page" href="main.jsp">Home</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">환영합니다!</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">게시판</a>
    </li>
    <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" data-bs-toggle="dropdown" href="#" role="button" aria-expanded="false">회원페이지</a>
        <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="signup.jsp">회원가입</a></li>
            <li><a class="dropdown-item active" href="login.jsp">로그인</a></li>
        </ul>
    </li>
</ul>
<div class="container">
    <h2 style="text-align:center; color: cornflowerblue">회원가입</h2>
    <form method="post" action="loginaction.jsp">
        <div  class="input-group mb-3">
            <input type="text" class="form-control" placeholder="아이디" name="id">
        </div>
        <div  class="input-group mb-3">
            <input type="password" class="form-control" placeholder="비밀번호" name="password">
        </div>
        <div class="nav justify-content-end">
            <input type="submit" class="btn btn-primary form-control"  value="로그인">
        </div>
    </form>
</div>
</body>
</html>