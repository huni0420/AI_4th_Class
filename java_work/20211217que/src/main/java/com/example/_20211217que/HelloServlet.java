package com.example._20211217que;

import sun.nio.cs.ext.EUC_KR;

import java.io.*;
import java.util.Arrays;
import javax.servlet.ServletException;
import javax.servlet.http.*;
import javax.servlet.annotation.*;

@WebServlet(name = "helloServlet", value = "/hello-servlet")
public class HelloServlet extends HttpServlet {
    private String message;

    public void init() {
        message = "Hello World!";
    }

    public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
        response.setContentType("text/html");

        // Hello
        PrintWriter out = response.getWriter();
        out.println("<html><body>");
        out.println("<h1>" + message + "</h1>");
        out.println("</body></html>");
    }

    public void doPost(HttpServletRequest req, HttpServletResponse res) throws ServletException, IOException {
        res.setCharacterEncoding("EUC-KR");

        String id = req.getParameter("id");
        String pw = req.getParameter("pw");
        String pwa = req.getParameter("pwa");
        String gender = req.getParameter("gender");

        String[] hobby = req.getParameterValues("hobby");
        String[] favorates = req.getParameterValues("favorate");


        PrintWriter out = res.getWriter();
        out.println("<html><head></head><body>");
        out.println("아이디: "+id+"<br>"+"비밀번호: "+pw+"<br>"+"비밀번호 확인: "+pwa+"<br>"+"성별: "+gender+"<br>"+"취미: "+ Arrays.toString(hobby)+"<br>"+"좋아하는것: "+Arrays.toString(favorates)+"<br>");
        out.println("</body></html>");




    }

    public void destroy() {
    }
}