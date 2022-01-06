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