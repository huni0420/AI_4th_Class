<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example.member.MemberDao" %>

<jsp:useBean id="dto" class="com.example.member.MemberDto">
</jsp:useBean>
<jsp:setProperty name="dto" property="*"></jsp:setProperty>
<%=dto%>
<%
    // db 저장 로직...
    MemberDao dao = new MemberDao();
    dao.memberset(dto,true);

    response.sendRedirect("/20211227_war_exploded/index.jsp");
%>