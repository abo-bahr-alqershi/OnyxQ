using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CreditCardType Entity
/// </summary>
public class CreditCardType : Entity<CreditCardTypeId>
{

    private CreditCardType() { }

    public CreditCardType(CreditCardTypeId id, decimal? creditCardNumberFull)
    {
        Id = id;
        CreditCardNumberFull = creditCardNumberFull;
    }

    /// <summary>
    /// The unique identifier for the CreditCardType
    /// المعرف الفريد لـ CreditCardType
    /// </summary>
    public CreditCardTypeId Id { get; private set; }

    /// <summary>
    /// CreditCardNumberFull of the CreditCardType
    /// CreditCardNumberFull الخاص بـ CreditCardType
    /// </summary>
    public decimal? CreditCardNumberFull { get; private set; }

    /// <summary>
    /// CreditCardName of the CreditCardType
    /// CreditCardName الخاص بـ CreditCardType
    /// </summary>
    public string CreditCardName { get; private set; }

    /// <summary>
    /// CreditCardNameEnglish of the CreditCardType
    /// CreditCardNameEnglish الخاص بـ CreditCardType
    /// </summary>
    public string CreditCardNameEnglish { get; private set; }

    /// <summary>
    /// BankAccount of the CreditCardType
    /// BankAccount الخاص بـ CreditCardType
    /// </summary>
    public string BankAccount { get; private set; }

    /// <summary>
    /// CommissionAccount of the CreditCardType
    /// CommissionAccount الخاص بـ CreditCardType
    /// </summary>
    public string CommissionAccount { get; private set; }

    /// <summary>
    /// CommissionPercent of the CreditCardType
    /// CommissionPercent الخاص بـ CreditCardType
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionCalcType of the CreditCardType
    /// CommissionCalcType الخاص بـ CreditCardType
    /// </summary>
    public decimal? CommissionCalcType { get; private set; }

    /// <summary>
    /// DuePeriod of the CreditCardType
    /// DuePeriod الخاص بـ CreditCardType
    /// </summary>
    public decimal? DuePeriod { get; private set; }

    /// <summary>
    /// MachineNumberBank of the CreditCardType
    /// MachineNumberBank الخاص بـ CreditCardType
    /// </summary>
    public decimal? MachineNumberBank { get; private set; }

    /// <summary>
    /// MachineNumber of the CreditCardType
    /// MachineNumber الخاص بـ CreditCardType
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// AccountReceiptLetter of the CreditCardType
    /// AccountReceiptLetter الخاص بـ CreditCardType
    /// </summary>
    public string AccountReceiptLetter { get; private set; }

    /// <summary>
    /// BankNumber of the CreditCardType
    /// BankNumber الخاص بـ CreditCardType
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// CommissionAmount of the CreditCardType
    /// CommissionAmount الخاص بـ CreditCardType
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// MaxCommissionPercent of the CreditCardType
    /// MaxCommissionPercent الخاص بـ CreditCardType
    /// </summary>
    public decimal? MaxCommissionPercent { get; private set; }

    /// <summary>
    /// MaxCommissionAmount of the CreditCardType
    /// MaxCommissionAmount الخاص بـ CreditCardType
    /// </summary>
    public decimal? MaxCommissionAmount { get; private set; }

    /// <summary>
    /// AccountCurrencyMaxCommission of the CreditCardType
    /// AccountCurrencyMaxCommission الخاص بـ CreditCardType
    /// </summary>
    public string AccountCurrencyMaxCommission { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the CreditCardType
    /// ConnectionBranchNumber الخاص بـ CreditCardType
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// ConnectionTerminalName of the CreditCardType
    /// ConnectionTerminalName الخاص بـ CreditCardType
    /// </summary>
    public string ConnectionTerminalName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CreditCardType CreditCardType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

