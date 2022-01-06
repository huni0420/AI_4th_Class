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
<ul class="nav" style="border-color: darkgrey">
    <li class="nav-item">
        <a class="nav-link active" aria-current="page" href="main.jsp">Logo</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="signup.jsp">Memberform</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#">Memberlist</a>
    </li>
    <li class="nav-item dropdown">
        <a class="nav-link dropdown-toggle" data-bs-toggle="dropdown" href="#" role="button" aria-expanded="false">게시판페이지</a>
        <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="board.jsp">Board</a></li>
            <li><a class="dropdown-item" href="boardlist.jsp">Boardlist</a></li>
            <li><a class="dropdown-item" href="#">로그아웃</a></li>
        </ul>
    </li>
</ul>
</body>
</html>
<div class="container">
    <h2 style="text-align:center; color: cornflowerblue">회원가입</h2>
    <div  class="input-group mb-3">
        <input type="text" class="form-control" placeholder="아이디" aria-describedby="basic-addon1">
    </div>
    <div  class="input-group mb-3">
        <input type="password" class="form-control" placeholder="비밀번호" aria-describedby="basic-addon1">
    </div>
    <div  class="input-group mb-3">
        <input type="email" class="form-control" placeholder="이메일" aria-describedby="basic-addon1">
    </div>
    <div  class="input-group mb-3">
        <input type="radio" class="btn-check" name="options-outlined" id="success-outlined" autocomplete="off" checked>
        <label class="btn btn-outline-success" for="success-outlined">남자</label>

        <input type="radio" class="btn-check" name="options-outlined" id="danger-outlined" autocomplete="off">
        <label class="btn btn-outline-danger" for="danger-outlined">여자</label>
    </div>
    <div class="nav justify-content-end">
        <input type="submit" class="btn btn-primary form-control"  value="회원가입">
    </div>
</div>
</body>
</html>