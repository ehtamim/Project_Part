package com.service;

import com.domain.TaxCalculate;
import com.domain.User;

import java.util.List;

public interface TaxCalculateService {
    public TaxCalculate insert(TaxCalculate taxCalculate);

    public TaxCalculate get(Long id);

    public List<TaxCalculate> getAll();
    public List<TaxCalculate> findByUserId(Long id);
    public List<TaxCalculate> getByUserId(Long id);
}
