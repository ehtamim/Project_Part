package com.service;

import com.domain.Authority;
import com.domain.User;
import com.repository.AuthorityRepository;
import com.repository.UserRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
@Transactional
public class AuthorityServiceImpl implements AuthorityService {

    private AuthorityRepository authorityRepository;

    public AuthorityServiceImpl(AuthorityRepository authorityRepository) {
        this.authorityRepository = authorityRepository;
    }

    @Transactional
    public Authority insert(Authority authority) {
        return authorityRepository.create(authority);
    }

    @Transactional(readOnly = true)
    public Authority get(Long id) {
        return authorityRepository.get(id);
    }

    @Transactional(readOnly = true)
    public List<Authority> getAll() {
        return authorityRepository.getAll();
    }

    @Transactional
    public Authority update(Authority authority) {
        return authorityRepository.update(authority);
    }

    @Transactional
    public void delete(Long id) {
        authorityRepository.delete(id);
    }
}