<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2022-01-03
  Time: 오전 9:29
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <%@ include file="boot.jsp"%>
    <title>JSP 로그인 페이지</title>
</head>
<body>
<ul class="nav" style="background-color: cornflowerblue;">
    <li class="nav-item">
        <a class="nav-link active" aria-current="page" href="main.jsp" style=" color: bisque">Logo</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="signup.jsp" style=" color: bisque">Memberform</a>
    </li>
    <li class="nav-item">
        <a class="nav-link" href="#" style=" color: bisque">Memberlist</a>
    </li>
    <li class="nav-item dropdown" >
        <a class="nav-link dropdown-toggle" data-bs-toggle="dropdown" href="#" role="button" aria-expanded="false" style=" color: bisque">게시판페이지</a>
        <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="board.jsp">Board</a></li>
            <li><a class="dropdown-item" href="boardlist.jsp">Boardlist</a></li>
            <li><a class="dropdown-item" href="#">로그아웃</a></li>
        </ul>
    </li>
</ul>
<div class="container">
    <div class="row p-3">
        <div class="col-md-4">
            <form action="/Home_war_exploded/loginaction.jsp">
                <h2 style="text-align:center; color: cornflowerblue">로그인</h2>
                <form method="post" action="loginaction.jsp">
                    <p>ID:</p>
                    <div  class="input-group mb-4">
                        <input type="text" class="form-control" placeholder="아이디" name="Id">
                    </div>
                    <p>Password:</p>
                    <div  class="input-group mb-4">
                        <input type="password" class="form-control" placeholder="비밀번호" name="Password">
                    </div>
                    <div class="nav justify-content-end">
                        <input type="submit" class="btn btn-primary form-control"  value="로그인">
                    </div>
                </form>
            </form>
        </div>
        <div class="col-md-8">
            <h1>광고창</h1>
            <iframe width="100%" height="360" src="https://www.youtube.com/embed/S7XLVTMHRmQ"></iframe>
        </div>
    </div>
    <div class="row p-3">
        <div class="col-md-12">
            <div class="jumbotron">
                <h1 style="color: crimson;">Issue Tab</h1>
                <p>.</p>
            </div>
            <p>로렘 입숨(lorem ipsum; 줄여서 립숨, lipsum)은 출판이나 그래픽 디자인 분야에서 폰트, 타이포그래피, 레이아웃 같은 그래픽 요소나 시각적 연출을 보여줄 때 사용하는 표준 채우기 텍스트로, 최종 결과물에 들어가는 실제적인 문장 내용이 채워지기 전에 시각 디자인 프로젝트 모형의 채움 글로도 이용된다. 이런 용도로 사용할 때 로렘 입숨을 그리킹(greeking)이라고도 부르며, 때로 로렘 입숨은 공간만 차지하는 무언가를 지칭하는 용어로도 사용된다.

                로렘 입숨은 전통 라틴어와 닮은 점 때문에 종종 호기심을 유발하기도 하지만 그 이상의 의미를 담지는 않는다. 문서에서 텍스트가 보이면 사람들은 전체적인 프레젠테이션보다는 텍스트에 담긴 뜻에 집중하는 경향이 있어서 출판사들은 서체나 디자인을 보일 때는 프레젠테이션 자체에 초점을 맞추기 위해 로렘 입숨을 사용한다.

                로렘 입숨은 영어에서 사용하는 문자들의 전형적인 분포에 근접하다고도 하는데, 이 점 때문에 프레젠테이션으로 초점을 이동하는 데에도 도움을 준다.</p>
            <p>로렘 입숨(lorem ipsum; 줄여서 립숨, lipsum)은 출판이나 그래픽 디자인 분야에서 폰트, 타이포그래피, 레이아웃 같은 그래픽 요소나 시각적 연출을 보여줄 때 사용하는 표준 채우기 텍스트로, 최종 결과물에 들어가는 실제적인 문장 내용이 채워지기 전에 시각 디자인 프로젝트 모형의 채움 글로도 이용된다. 이런 용도로 사용할 때 로렘 입숨을 그리킹(greeking)이라고도 부르며, 때로 로렘 입숨은 공간만 차지하는 무언가를 지칭하는 용어로도 사용된다.

                로렘 입숨은 전통 라틴어와 닮은 점 때문에 종종 호기심을 유발하기도 하지만 그 이상의 의미를 담지는 않는다. 문서에서 텍스트가 보이면 사람들은 전체적인 프레젠테이션보다는 텍스트에 담긴 뜻에 집중하는 경향이 있어서 출판사들은 서체나 디자인을 보일 때는 프레젠테이션 자체에 초점을 맞추기 위해 로렘 입숨을 사용한다.

                로렘 입숨은 영어에서 사용하는 문자들의 전형적인 분포에 근접하다고도 하는데, 이 점 때문에 프레젠테이션으로 초점을 이동하는 데에도 도움을 준다.</p>
        </div>
    </div>
</div>
</body>
</html>
