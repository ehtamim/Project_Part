package com.controller;

import com.domain.Authority;
import com.exception.BadRequestAlertException;
import com.exception.NotFoundAlertException;
import com.service.AuthorityService;
import org.springframework.beans.propertyeditors.StringTrimmerEditor;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.WebDataBinder;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.net.URI;
import java.util.List;
import java.util.Optional;

@Controller
@RequestMapping("/authority")
public class AuthorityController {

    private AuthorityService authorityService;

    public AuthorityController(AuthorityService authorityService) {
        this.authorityService = authorityService;
    }

    @InitBinder
    public void initBinder(WebDataBinder webDataBinder) {
        StringTrimmerEditor stringTrimmerEditor = new StringTrimmerEditor(true);
        webDataBinder.registerCustomEditor(String.class, stringTrimmerEditor);
    }

    @PostMapping("/authorities")
    public ResponseEntity<Authority> createAuthority(@Valid @RequestBody Authority authority) throws Exception {
        if (authority.getId() != null) {
            throw new BadRequestAlertException("A new authority cannot have an id value");
        }
        authorityService.insert(authority);
        return ResponseEntity.created(new URI("/authorities/"))
                .body(authority);
    }

    @PutMapping("/authorities")
    public ResponseEntity<Authority> updateAuthority(@Valid @RequestBody Authority authority) throws Exception {
        if (authority.getId() == null) {
            throw new BadRequestAlertException("Invalid id");
        }
        authorityService.update(authority);
        return ResponseEntity.created(new URI("/authorities/"))
                .body(authority);
    }

    @GetMapping("/authorities")
    public ResponseEntity<List<Authority>> getAllAuthorities() {
        List<Authority> authorities = authorityService.getAll();
        return ResponseEntity.ok().body(authorities);
    }

    @GetMapping("/authorities/{id}")
    public ResponseEntity<Authority> getAuthority(@PathVariable Long id) {
        Optional<Authority> authority = Optional.ofNullable(authorityService.get(id));
        if (authority.isPresent()) {
            return ResponseEntity.ok().body(authority.get());
        }
        throw new NotFoundAlertException("Record not found [" + id + "]");
    }

    @DeleteMapping("/authorities/{id}")
    public ResponseEntity<Authority> deleteAuthority(@PathVariable Long id) {
        authorityService.delete(id);
        return ResponseEntity.noContent().build();
    }
}
