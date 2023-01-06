package com.domain;

import javax.persistence.*;
import javax.validation.constraints.NotNull;
import java.time.LocalDate;
import java.util.Date;

@Entity
@Table(name = "tax_calculated")
public class TaxCalculate {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    @Column(name = "user_id")
    private Long user_id;
    @NotNull
    @Column(name = "date")
    private LocalDate date;
    @NotNull
    @Column(name = "basicSalary")
    private double basicSalary;
    @NotNull
    @Column(name = "houseRent")
    private double houseRent;
    @NotNull
    @Column(name = "medicalAllowance")
    private double medicalAllowance;
    @NotNull
    @Column(name = "conveyance")
    private double conveyance;
    @NotNull
    @Column(name = "festivalBonus")
    private double festivalBonus;
    @NotNull
    @Column(name = "taxAbleIncome")
    private double taxAbleIncome;
    @NotNull
    @Column(name = "taxLiability")
    private double taxLiability;
    @NotNull
    @Column(name = "rebate")
    private double rebate;
    @NotNull
    @Column(name = "netTax")
    private double netTax;

    public static void add(TaxCalculate t) {
    }

    public Long getUser_id() {return user_id;}
    public void setUser_id(Long user_id) {this.user_id=user_id;}
    public LocalDate getDate(){return date;}
    public void setDate(LocalDate date) {this.date=date;}
    public void setBasicSalary(double basicSalary) {this.basicSalary = basicSalary;}
    public double getBasicSalary() {return basicSalary;}
    public void setHouseRent(double houseRent) {this.houseRent = houseRent;}
    public double getHouseRent() {return houseRent;}
    public void setMedicalAllowance(double medicalAllowance) {this.medicalAllowance = medicalAllowance;}
    public double getMedicalAllowance() {return medicalAllowance;}
    public void setConveyance(double conveyance) {this.conveyance = conveyance;}
    public double getConveyance() {return conveyance;}
    public void setFestivalBonus(double festivalBonus) {this.festivalBonus = festivalBonus;}
    public double getFestivalBonus() {return festivalBonus;}
    public double getTaxAbleIncome() {return taxAbleIncome;}
    public void setTaxAbleIncome(double taxAbleIncome) {this.taxAbleIncome = taxAbleIncome;}
    public void setTaxLiability(double taxLiability) {this.taxLiability = taxLiability;}
    public double getTaxLiability() {return taxLiability;}
    public void setRebate(double rebate) {this.rebate = rebate;}
    public double getRebate() {return rebate;}
    public void setNetTax(double netTax) {this.netTax = netTax;}
    public double getNetTax() {return netTax;}
}
