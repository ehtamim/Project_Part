package com.service;

import com.domain.User;
//import com.repository.LeaveApplicationRepository;
import com.repository.UserRepository;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
@Transactional
public class UserServiceImpl implements UserService {
    private UserRepository userRepository;
    private PasswordEncoder passwordEncoder;
    public UserServiceImpl(UserRepository userRepository, PasswordEncoder passwordEncoder) {
        this.userRepository = userRepository;
        this.passwordEncoder = passwordEncoder;
    }
    @Transactional
    public User insert(User user) {
        user.setPassword(passwordEncoder.encode(user.getPassword()));
        return userRepository.create(user);
    }
    @Transactional(readOnly = true)
    public User get(Long id) {
        return userRepository.get(id);
    }

    @Transactional(readOnly = true)
    public List<User> getAll() {
        return userRepository.getAll();
    }

    @Transactional
    public User update(User user) {
        user.setPassword(passwordEncoder.encode(user.getPassword()));
        return userRepository.update(user);
    }

    @Transactional
    public void delete(Long id) {
        userRepository.delete(id);
    }
    @Transactional(readOnly = true)
    public User getByUsername(String username) { return userRepository.getByUsername(username); }

    @Override
    public User fetchUserByUsername(String username) { return userRepository.getByUsername(username); }

    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        User user = getByUsername(username);
        if (user == null) {
            throw new UsernameNotFoundException("User not found");
        }
        return new org.springframework.security.core.userdetails.User(user.getUsername(), user.getPassword(), user.getAuthorities());
    }
}