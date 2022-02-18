package com.example.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HelloController {
    @GetMapping("index")
    public String index(Model model,
                        @RequestParam(required = false,defaultValue = "default",value = "name") String name
    ) {
        model.addAttribute("name",name);
        return "index";
    }
}
