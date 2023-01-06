package com.repository;

import com.domain.TaxCalculate;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public class TaxCalculateRepositoryImpl implements TaxCalculateRepository{
    private SessionFactory sessionFactory;

    public TaxCalculateRepositoryImpl(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }

    public List<TaxCalculate> getAll() {
        Session session = sessionFactory.getCurrentSession();
        Query<TaxCalculate> userQuery = session.createQuery("from TaxCalculate", TaxCalculate.class);
        return userQuery.getResultList();
    }

    public TaxCalculate create(TaxCalculate taxCalculate) {
        Session session = sessionFactory.getCurrentSession();
        session.save(taxCalculate);
        return taxCalculate;
    }

    public TaxCalculate get(Long id) {
        Session session = sessionFactory.getCurrentSession();
        return session.get(TaxCalculate.class, id);
    }

    public List<TaxCalculate> findById(Long id){
        Session session = sessionFactory.getCurrentSession();
        Query<TaxCalculate> userQuery = session.createQuery("from TaxCalculate", TaxCalculate.class);
        return userQuery.getResultList();
    }

    @Override
    public List<TaxCalculate> getByUserId(Long id) {
        Session session = sessionFactory.getCurrentSession();
        Query<TaxCalculate> userQuery = session.createQuery("from TaxCalculate where user_id = :id", TaxCalculate.class);
        userQuery.setParameter("id", id);
        return userQuery.list();
    }
}
