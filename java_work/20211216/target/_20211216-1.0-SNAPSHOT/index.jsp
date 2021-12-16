<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-16
  Time: 오전 11:57
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%!
    // 메서드를 정의 할수가 있다....
    public void doA(){
        System.out.println("test");
    }
%>
<%
    doA();
    doA();
%>
<h1>
    <%= "Hello World!" %><br>
    <% out.print("Hello World!"); %>
</h1>
<a href="hello-servlet">Hello Servlet</a><br>
<a href="MyServlet">MyServlet</a><br>
한글이 나오냐
<form action="submit.jsp" method="post">
    <input type="text" name="aa" value="한글">
    <input type="submit" value="전송">
</form>
</body>
</html>
