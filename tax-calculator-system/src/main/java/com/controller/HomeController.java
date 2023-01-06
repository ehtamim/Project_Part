package com.controller;

import com.domain.User;
import com.service.UserService;
import org.springframework.stereotype.Controller;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.validation.Valid;
import java.sql.SQLException;

@Controller
public class HomeController {
    private final UserService userService;

    public HomeController(UserService userService) {
        this.userService = userService;
    }

    @RequestMapping("/signup")
    public String signup() {
        return "SignUp";
    }

    @RequestMapping("/submitSignup")
    public String submit(@Valid @ModelAttribute("user") User user,
                         BindingResult bindingResult) throws SQLException {
        if (bindingResult.hasErrors()) {
            return "SignUp";
        }
        else {
            if(user.getAge()<65)
            {
                user.setSenior(false);
            }
            else
            {
                user.setSenior(true);
            }
            userService.insert(user);
            return "redirect:/tax_calculator_system_war_exploded/";
        }
    }
}
