package com.controller;

import com.domain.TaxVariables;
import com.domain.User;
import com.service.TaxVariablesService;
import com.service.UserService;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;

import javax.validation.Valid;
import java.security.Principal;
import java.sql.SQLException;
import java.util.List;

@Controller
@RequestMapping("/admin")
public class AdminController {
    private final UserService userService;
    private final TaxVariablesService taxVariablesService;
    public Long useridForUpDelOp;

    public AdminController(UserService userService, TaxVariablesService taxVariablesService) {
        this.userService = userService;
        this.taxVariablesService = taxVariablesService;
    }

    @RequestMapping("/dashboard")
    public String dashboard(Model model) {
        List<User> dashboardData=userService.getAll();
        model.addAttribute("allUser", dashboardData);
        return "AdminDashboard";
    }

    /////////////////////////USER RELATED
    @RequestMapping("/addUser")
    public String submit(@Valid @ModelAttribute("addUser") User user,
                         BindingResult bindingResult) throws SQLException {
        if (bindingResult.hasErrors()) {
            return "AddUser";
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
            return "redirect:/admin/dashboard";
        }
    }
    @RequestMapping("/updateDeleteUser")
    public String upDel(@ModelAttribute("useridForUpDel") String id,Model model) throws SQLException {
        useridForUpDelOp=Long.parseLong(id);
        User user=userService.get(useridForUpDelOp);
        model.addAttribute("updateUserData", user);
        return "UpdateUser";
    }
    @RequestMapping("/updateUser")
    public String userUpdate(@Valid @ModelAttribute("updateUserData") User user,
                               BindingResult bindingResult) throws SQLException {
        if (bindingResult.hasErrors()) {
            return "redirect:/admin/updateDeleteUser";
        }
        else {
            user.setId(useridForUpDelOp);
            if(user.getAge()<65)
            {
                user.setSenior(false);
            }
            else
            {
                user.setSenior(true);
            }
            userService.update(user);
            return "redirect:/admin/dashboard";
        }
    }

    @RequestMapping("deleteUser")
    public String profileDelete(User user)
    {
        userService.delete(useridForUpDelOp);
        return "redirect:/admin/dashboard";
    }

    ////////////////////////TAX RELATED
    @RequestMapping("/taxVariables")
    public String showTaxVariables(Model model) {
        TaxVariables taxVariables=taxVariablesService.get(1L);
        model.addAttribute("taxVarUpdate", taxVariables);
        return "TaxVariables";
    }
    @RequestMapping("/updateTaxVariables")
    public String taxVarUpdate(@Valid @ModelAttribute("taxVarUpdate") TaxVariables taxVariables,
                                BindingResult bindingResult) throws SQLException {
        if (bindingResult.hasErrors()) {
            return "TaxVariables";
        }
        else {
            taxVariables.setId(1L);
            taxVariables.setNext1(taxVariables.getNext1()/100);
            taxVariables.setNext3(taxVariables.getNext3()/100);
            taxVariables.setNext4(taxVariables.getNext4()/100);
            taxVariables.setNext5(taxVariables.getNext5()/100);
            taxVariables.setRest(taxVariables.getRest()/100);
            taxVariablesService.update(taxVariables);
            return "redirect:/admin/taxVariables";
        }
    }
}
