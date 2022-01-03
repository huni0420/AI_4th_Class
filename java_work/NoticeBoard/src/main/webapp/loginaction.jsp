<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2022-01-03
  Time: 오전 9:29
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example.noticeboard.user.userDAO"%>
<%@ page import="java.io.PrintWriter"%>
<% request.setCharacterEncoding("UTF-8");%>
<jsp:useBean id="user" class="com.example.noticeboard.user.user" scope="page"/>
<jsp:setProperty name="user" property="id"/>
<jsp:setProperty name="user" property="password"/>
<html>
<head>
    <%@ include file="boot.jsp"%>
    <title>JSP 로그인 페이지</title>
</head>
<body>
<%
    userDAO userDAO = new userDAO();
    int result = userDAO.login(user.getId(),user.getPassword());
    if(result == 1){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("location.href = 'main.jsp'");
        script.println("<script>");
    }
    else if(result == 0){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("alert('비밀번호가 틀립니다.')");
        script.println("history.back()");
        script.println("<script>");
    }
    else if(result == -1){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("alert('존재하지 않는 아이디 입니다.')");
        script.println("history.back()");
        script.println("<script>");
    }
    else if(result == -2){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("alert('데이터베이스 오류가 발생했습니다.')");
        script.println("history.back()");
        script.println("<script>");
    }
%>
</body>
</html>
