<%@ page language="java" contentType="text/html; charset=UTF-8"
         pageEncoding="UTF-8"%>
<%request.setCharacterEncoding("UTF-8"); %>
<html>
<head>
    <%@ include file="../boot.jsp"%>
    <title>Title</title>
</head>
<body>
<%@ include file="../nav.jsp"%>
<h1>파일업로드</h1>
<div class="container">
    <form action="fileuploadform.jsp"
        name ="frm"
        method="post"
        enctype="multipart/form-data">
        aa=<input type="text">
    </form>

</div>
</body>
</html>
