package com.repository;

import com.domain.Authority;
import com.domain.User;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class AuthorityRepositoryImpl implements AuthorityRepository {

    private SessionFactory sessionFactory;

    public AuthorityRepositoryImpl(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }

    public List<Authority> getAll() {
        Session session = sessionFactory.getCurrentSession();
        Query<Authority> authorityQuery = session.createQuery("from Authority", Authority.class);
        return authorityQuery.getResultList();
    }

    public Authority create(Authority authority) {
        Session session = sessionFactory.getCurrentSession();
        session.save(authority);
        return authority;
    }

    public Authority get(Long id) {
        Session session = sessionFactory.getCurrentSession();
        return session.get(Authority.class, id);
    }

    public Authority update(Authority authority) {
        Session session = sessionFactory.getCurrentSession();
        session.saveOrUpdate(authority);
        return authority;
    }

    public void delete(Long id) {
        Session session = sessionFactory.getCurrentSession();
        Authority authority = get(id);
        if (authority != null) {
            session.delete(authority);
        }
    }
}