package com.service;

import com.domain.TaxVariables;
import com.repository.TaxVariablesRepository;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import java.util.List;

@Service
@Transactional
public class TaxVariablesServiceImpl implements TaxVariablesService {
    private TaxVariablesRepository taxVariablesRepository;
    public TaxVariablesServiceImpl(TaxVariablesRepository taxVariablesRepository) {
        this.taxVariablesRepository = taxVariablesRepository;
    }
    @Transactional
    public TaxVariables insert(TaxVariables taxVariables) {
        return taxVariablesRepository.create(taxVariables);
    }
    @Transactional(readOnly = true)
    public TaxVariables get(Long id) {
        return taxVariablesRepository.get(id);
    }

    @Transactional(readOnly = true)
    public List<TaxVariables> getAll() {
        return taxVariablesRepository.getAll();
    }

    @Transactional
    public TaxVariables update(TaxVariables taxVariables) {
        return taxVariablesRepository.update(taxVariables);
    }
}
