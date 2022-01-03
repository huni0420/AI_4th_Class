<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="com.example.member.MemberDao" %>

<jsp:useBean id="dto" class="com.example.member.MemberDto">
</jsp:useBean>
<jsp:setProperty name="dto" property="*"></jsp:setProperty>
<%=dto%>
<%
    // db 저장 로직...
    MemberDao dao = new MemberDao();
    // update 함수 호출
    String ret = dao.memberset(dto,true);

    if(ret.equals("true"))
        response.sendRedirect("/20211227_war_exploded/member/memberlist.jsp");
    else
        out.println("sql 문 실행 실패");
%>