package com.service;

import com.domain.TaxVariables;

import java.util.List;

public interface TaxVariablesService {
    public TaxVariables insert(TaxVariables taxVariables);

    public TaxVariables get(Long id);

    public List<TaxVariables> getAll();

    public TaxVariables update(TaxVariables taxVariables);
}
