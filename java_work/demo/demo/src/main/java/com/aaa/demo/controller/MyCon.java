package com.aaa.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class MyCon {

    @GetMapping("/aa")
    public String doA(){
        return "aa";
    }
}
