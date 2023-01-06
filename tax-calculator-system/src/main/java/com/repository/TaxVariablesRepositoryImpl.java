package com.repository;

import com.domain.TaxVariables;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.springframework.stereotype.Repository;
import java.util.List;

@Repository
public class TaxVariablesRepositoryImpl implements TaxVariablesRepository{
    private SessionFactory sessionFactory;

    public TaxVariablesRepositoryImpl(SessionFactory sessionFactory) {
        this.sessionFactory = sessionFactory;
    }

    public List<TaxVariables> getAll() {
        Session session = sessionFactory.getCurrentSession();
        Query<TaxVariables> userQuery = session.createQuery("from TaxVariables", TaxVariables.class);
        return userQuery.getResultList();
    }

    public TaxVariables create(TaxVariables taxVariables) {
        Session session = sessionFactory.getCurrentSession();
        session.save(taxVariables);
        return taxVariables;
    }

    public TaxVariables get(Long id) {
        Session session = sessionFactory.getCurrentSession();
        return session.get(TaxVariables.class, id);
    }

    public TaxVariables update(TaxVariables taxVariables) {
        Session session = sessionFactory.getCurrentSession();
        session.update(taxVariables);
        return taxVariables;
    }
}
