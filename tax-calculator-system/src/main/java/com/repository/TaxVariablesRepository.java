package com.repository;

import com.domain.TaxVariables;

import java.util.List;

public interface TaxVariablesRepository {
    public List<TaxVariables> getAll();

    public TaxVariables create(TaxVariables taxVariables);

    public TaxVariables get(Long id);

    public TaxVariables update(TaxVariables taxVariables);
}
