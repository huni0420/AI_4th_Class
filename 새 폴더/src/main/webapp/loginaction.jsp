<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example.home.user.userDAO"%>
<%@ page import="java.io.PrintWriter"%>
<% request.setCharacterEncoding("UTF-8");%>
<jsp:useBean id="user" class="com.example.home.user.user" scope="page"/>
<jsp:setProperty name="user" property="id"/>
<jsp:setProperty name="user" property="password"/>
<html>
<head>
    <title>JSP 로그인 페이지</title>
</head>
<body>
<h1>연경을 됨</h1>
<%
    userDAO userDAO = new userDAO();
    int result = userDAO.login(user.getId(),user.getPassword());
    if(result == 1){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("location.href='main.jsp'");
        script.println("</script>");
        System.out.println("연결성공");
    }
    else if(result == 0){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("alert('비밀번호가 틀립니다.')");
        script.println("history.back()");
        script.println("</script>");
        System.out.println("실패1");
    }
    else if(result == -1){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("alert('존재하지 않는 아이디 입니다.')");
        script.println("history.back()");
        script.println("</script>");
        System.out.println("실 패2");
    }
    else if(result == -2){
        PrintWriter script = response.getWriter();
        script.println("<script>");
        script.println("alert('데이터베이스 오류가 발생했습니다.')");
        script.println("history.back()");
        script.println("</script>");
        System.out.println("실패3");
    }
%>
</body>
</html>
