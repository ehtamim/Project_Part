package com.repository;

import com.domain.User;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class UserRepositoryImpl implements UserRepository {
    public Long userId;

    private SessionFactory sessionFactory;

    public UserRepositoryImpl(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }

    public List<User> getAll() {
        Session session = sessionFactory.getCurrentSession();
        Query<User> userQuery = session.createQuery("from User", User.class);
        return userQuery.getResultList();
    }

    public User create(User user) {
        Session session = sessionFactory.getCurrentSession();
        session.save(user);
        return user;
    }

    public User get(Long id) {
        Session session = sessionFactory.getCurrentSession();
        return session.get(User.class, id);
    }

    public User update(User user) {
        Session session = sessionFactory.getCurrentSession();
        session.update(user);
        return user;
    }

    public void delete(Long id) {
        Session session = sessionFactory.getCurrentSession();
        User user = get(id);
        if (user != null) {
            session.delete(user);
        }
    }

    @Override
    public User getByUsername(String username) {
        Session session = sessionFactory.getCurrentSession();
        Query<User> userQuery = session.createQuery("from User where username = :username", User.class);
        userQuery.setParameter("username", username);
        return userQuery.getSingleResult();
    }

    @Override
    public User getUserByUsername(String username) {
        Session session = sessionFactory.getCurrentSession();
        Query<User> userQuery = session.createQuery("from User where username = :username", User.class);
        //userQuery.setParameter("usernmae", username);
        userQuery.setParameter("id", userId);
        return userQuery.getSingleResult();
    }
}