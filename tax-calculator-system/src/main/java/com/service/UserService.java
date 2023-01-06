package com.service;

import com.domain.User;
import org.springframework.security.core.userdetails.UserDetailsService;

import java.util.List;

public interface UserService extends UserDetailsService {

    public User insert(User user);

    public User get(Long id);

    public List<User> getAll();

    public User update(User user);

    public void delete(Long id);

    public User getByUsername(String username);

    //User fetchUserById(int id);

    User fetchUserByUsername(String username);
}