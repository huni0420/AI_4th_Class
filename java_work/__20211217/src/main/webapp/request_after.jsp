<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-17
  Time: 오전 10:40
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h1>request.jsp</h1>
<%
    String a = request.getParameter("a");
    String b = request.getParameter("b");
    String gender = request.getParameter("gender");
    String chkvalues[] = request.getParameterValues("chk");

    out.print("a = "+a);
    out.print("b = "+b);
    out.print("gender = "+gender);
    out.print("chkvalues = "+chkvalues);
    if(chkvalues != null){
        out.print("chkvalues[0] = "+chkvalues[0]);
        out.print("chkvalues[1] = "+chkvalues[1]);
    }
    out.print("<br><br><br>");

    out.println(request.getRemoteAddr());
    out.println(request.getRequestURI());
    out.print("<br>");
%>
<div>
<a href="index.jsp">index.jpg로 메인페이지이동</a>
</div>
</body>
</html>
