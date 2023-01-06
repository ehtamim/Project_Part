package com.repository;

import com.domain.TaxCalculate;
import com.domain.User;

import java.util.List;

public interface TaxCalculateRepository {
    public List<TaxCalculate> getAll();

    public TaxCalculate create(TaxCalculate taxCalculate);

    public TaxCalculate get(Long id);
    public List<TaxCalculate> findById(Long id);
    public List<TaxCalculate> getByUserId(Long id);
}
