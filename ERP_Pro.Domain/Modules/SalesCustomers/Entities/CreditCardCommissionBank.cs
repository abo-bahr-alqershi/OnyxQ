using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CreditCardCommissionBank Entity
/// </summary>
public class CreditCardCommissionBank : Entity<CreditCardCommissionBankId>
{

    private CreditCardCommissionBank() { }

    public CreditCardCommissionBank(CreditCardCommissionBankId id, decimal? bankNumber, decimal? creditCardTypeFull)
    {
        Id = id;
        BankNumber = bankNumber;
        CreditCardTypeFull = creditCardTypeFull;
    }

    /// <summary>
    /// The unique identifier for the CreditCardCommissionBank
    /// المعرف الفريد لـ CreditCardCommissionBank
    /// </summary>
    public CreditCardCommissionBankId Id { get; private set; }

    /// <summary>
    /// BankNumber of the CreditCardCommissionBank
    /// BankNumber الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// CreditCardTypeFull of the CreditCardCommissionBank
    /// CreditCardTypeFull الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? CreditCardTypeFull { get; private set; }

    /// <summary>
    /// CommissionPercent of the CreditCardCommissionBank
    /// CommissionPercent الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// DuePeriod of the CreditCardCommissionBank
    /// DuePeriod الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? DuePeriod { get; private set; }

    /// <summary>
    /// MaxCommissionPercent of the CreditCardCommissionBank
    /// MaxCommissionPercent الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? MaxCommissionPercent { get; private set; }

    /// <summary>
    /// MaxCommissionAmount of the CreditCardCommissionBank
    /// MaxCommissionAmount الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? MaxCommissionAmount { get; private set; }

    /// <summary>
    /// AccountCurrencyMaxCommission of the CreditCardCommissionBank
    /// AccountCurrencyMaxCommission الخاص بـ CreditCardCommissionBank
    /// </summary>
    public string AccountCurrencyMaxCommission { get; private set; }

    /// <summary>
    /// CommissionAmount of the CreditCardCommissionBank
    /// CommissionAmount الخاص بـ CreditCardCommissionBank
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
