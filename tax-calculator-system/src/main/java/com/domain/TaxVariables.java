package com.domain;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity
@Table(name = "taxvariables")
public class TaxVariables {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @NotNull
    @Column(name = "house_rent")
    private Double houseRent;
    @NotNull
    @Column(name = "medical_allowance")
    private Double medicalAllowance;
    @NotNull
    @Column(name = "conveyance")
    private Double conveyance;
    @NotNull
    @Column(name = "festive_bonus")
    private Double festiveBonus;
    @NotNull
    @Column(name = "male_payable")
    private Double malePayable;
    @NotNull
    @Column(name = "female_payable")
    private Double femalePayable;
    @NotNull
    @Column(name = "disabled_payable")
    private Double disabledPayable;
    @NotNull
    @Column(name = "freedom_payable")
    private Double freedomPayable;
    @NotNull
    @Column(name = "next1")
    private Double next1;
    @NotNull
    @Column(name = "next3")
    private Double next3;
    @NotNull
    @Column(name = "next4")
    private Double next4;
    @NotNull
    @Column(name = "next5")
    private Double next5;
    @NotNull
    @Column(name = "rest")
    private Double rest;

    public void setId(Long id) {this.id = id;}
    public Long getId() {return id;}
    public void setHouseRent(Double houseRent) {this.houseRent = houseRent;}
    public Double getHouseRent() {return houseRent;}
    public void setMedicalAllowance(Double medicalAllowance) {this.medicalAllowance = medicalAllowance;}
    public Double getMedicalAllowance() {return medicalAllowance;}
    public void setConveyance(Double conveyance) {this.conveyance = conveyance;}
    public Double getConveyance() {return conveyance;}
    public void setFestiveBonus(Double festiveBonus) {this.festiveBonus = festiveBonus;}
    public Double getFestiveBonus() {return festiveBonus;}
    public void setMalePayable(Double malePayable) {this.malePayable = malePayable;}
    public Double getMalePayable() {return malePayable;}
    public void setFemalePayable(Double femalePayable) {this.femalePayable = femalePayable;}
    public Double getFemalePayable() {return femalePayable;}
    public void setDisabledPayable(Double disabledPayable) {this.disabledPayable = disabledPayable;}
    public Double getDisabledPayable() {return disabledPayable;}
    public void setFreedomPayable(Double freedomPayable) {this.freedomPayable = freedomPayable;}
    public Double getFreedomPayable() {return freedomPayable;}
    public void setNext1(Double next1) {this.next1 = next1;}
    public Double getNext1() {return next1;}
    public void setNext3(Double next3) {this.next3 = next3;}
    public Double getNext3() {return next3;}
    public void setNext4(Double next4) {this.next4 = next4;}
    public Double getNext4() {return next4;}
    public void setNext5(Double next5) {this.next5 = next5;}
    public Double getNext5() {return next5;}
    public void setRest(Double rest) {this.rest = rest;}
    public Double getRest() {return rest;}
}
