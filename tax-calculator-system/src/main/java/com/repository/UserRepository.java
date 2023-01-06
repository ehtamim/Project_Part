package com.repository;

import com.domain.User;
import java.util.List;
import java.util.Optional;

public interface UserRepository {

    public List<User> getAll();

    public User create(User user);

    public User get(Long id);

    public User update(User user);

    public void delete(Long id);
    //public User findByUsername(String username);

    public User getByUsername(String username);

    public User getUserByUsername(String username);
}