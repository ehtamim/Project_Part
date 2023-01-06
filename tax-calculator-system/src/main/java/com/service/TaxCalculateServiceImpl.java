package com.service;

import com.domain.TaxCalculate;
import com.repository.TaxCalculateRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
@Service
@Transactional
public class TaxCalculateServiceImpl implements TaxCalculateService{
    private TaxCalculateRepository taxCalculateRepository;
    public TaxCalculateServiceImpl(TaxCalculateRepository taxCalculateRepository) {
        this.taxCalculateRepository = taxCalculateRepository;
    }
    @Transactional
    public TaxCalculate insert(TaxCalculate taxCalculate) {
        return taxCalculateRepository.create(taxCalculate);
    }
    @Transactional(readOnly = true)
    public TaxCalculate get(Long id) {
        return taxCalculateRepository.get(id);
    }

    @Transactional(readOnly = true)
    public List<TaxCalculate> getAll() {
        return taxCalculateRepository.getAll();
    }
    @Transactional(readOnly = true)
    public List<TaxCalculate> findByUserId(Long id) {
        return taxCalculateRepository.findById(id);
    }
    @Override
    public List<TaxCalculate> getByUserId(Long id) { return taxCalculateRepository.getByUserId(id); }
}
