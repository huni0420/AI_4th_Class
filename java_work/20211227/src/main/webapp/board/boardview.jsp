<%@ page import="com.example.Board.BoardDao" %>
<%@ page import="com.example.Board.BoardDto" %>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
    <jsp:include page="../head.jsp"/>
    <%--
        주소줄에 있는 idx 값을 가지고 와서 해당 DAO idx 17번인 것을 가지고 와야 한다.
    --%>
    <%
        int idx = Integer.parseInt(request.getParameter("idx"));
        BoardDao bd = new BoardDao();
        BoardDto row =  bd.selectrow(idx);
    %>

</head>
<body>
<jsp:include page="../nav.jsp"/>
<div class="container">
    <h2>boardview</h2>
    <div style="border: 1px solid #ccc;
                border-radius: 3%;
                padding: 0.5rem;">
        <div class="form-group">
            <label>title</label>
            <strong<%=row.getTitle()%>>title 나와야함</strong>
            <label>name</label>
            <strong<%=row.getName()%>>name 나와야함</strong>
        </div>
        <div class="form-group">
            <label>content</label>
            <div>
                <%=row.getContent()%>
            </div>
            <hr>
            <div class="form-group">
                <label>작성일자</label>
                <div>
                    <%=row.getWdate()%>
                </div>
            </div>
        </div>
    </div>

        <button type="button" class="btn btn-primary">수정</button>
        <button type="button" class="btn btn-primary">삭제</button>
    </div>
</body>
</html>
