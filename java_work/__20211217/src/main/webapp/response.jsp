<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-17
  Time: 오전 10:55
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String send = request.getParameter("send");
    if(send.equals("true"))
        response.sendRedirect("index.jsp");
    else
        out.println("send 값은 false 입니다");
%>
<!---
    request 한페이지에서 동작을 한다.
    request_befo -> request_after
    request_after 에서만 getparameter로 구할수 있다.

    session 브라우저 창이 닫힐땎자ㅣ 동작을 한다.
    index.jsp setArttribute
--->
</body>
</html>
