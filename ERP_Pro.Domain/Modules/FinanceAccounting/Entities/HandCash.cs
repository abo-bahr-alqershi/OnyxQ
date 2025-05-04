using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// HandCash Entity
/// </summary>
public class HandCash : Entity<HandCashId>
{

    private HandCash() { }

    public HandCash(HandCashId id, decimal? cashNumber)
    {
        Id = id;
        CashNumber = cashNumber;
    }

    /// <summary>
    /// The unique identifier for the HandCash
    /// المعرف الفريد لـ HandCash
    /// </summary>
    public HandCashId Id { get; private set; }

    /// <summary>
    /// CashNumber of the HandCash
    /// CashNumber الخاص بـ HandCash
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CashName of the HandCash
    /// CashName الخاص بـ HandCash
    /// </summary>
    public string CashName { get; private set; }

    /// <summary>
    /// CashNameEnglish of the HandCash
    /// CashNameEnglish الخاص بـ HandCash
    /// </summary>
    public string CashNameEnglish { get; private set; }

    /// <summary>
    /// CashSerial of the HandCash
    /// CashSerial الخاص بـ HandCash
    /// </summary>
    public decimal? CashSerial { get; private set; }

    /// <summary>
    /// CashType of the HandCash
    /// CashType الخاص بـ HandCash
    /// </summary>
    public decimal? CashType { get; private set; }

    /// <summary>
    /// UseCashIncome of the HandCash
    /// UseCashIncome الخاص بـ HandCash
    /// </summary>
    public decimal? UseCashIncome { get; private set; }

    /// <summary>
    /// PosSystemFlag of the HandCash
    /// PosSystemFlag الخاص بـ HandCash
    /// </summary>
    public decimal? PosSystemFlag { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the HandCash
    /// ConnectionBranchNumber الخاص بـ HandCash
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// ConfigLastDate of the HandCash
    /// ConfigLastDate الخاص بـ HandCash
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// InactiveFlag of the HandCash
    /// InactiveFlag الخاص بـ HandCash
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the HandCash
    /// InactiveDate الخاص بـ HandCash
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the HandCash
    /// InactiveReason الخاص بـ HandCash
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ReceiptSerialType of the HandCash
    /// ReceiptSerialType الخاص بـ HandCash
    /// </summary>
    public decimal? ReceiptSerialType { get; private set; }

    /// <summary>
    /// PaymentTypeNumberDefault of the HandCash
    /// PaymentTypeNumberDefault الخاص بـ HandCash
    /// </summary>
    public decimal? PaymentTypeNumberDefault { get; private set; }

    /// <summary>
    /// ReceivedTypeNumberDefault of the HandCash
    /// ReceivedTypeNumberDefault الخاص بـ HandCash
    /// </summary>
    public decimal? ReceivedTypeNumberDefault { get; private set; }

    /// <summary>
    /// MediatorFlag of the HandCash
    /// MediatorFlag الخاص بـ HandCash
    /// </summary>
    public decimal? MediatorFlag { get; private set; }

    /// <summary>
    /// GroupNumber of the HandCash
    /// GroupNumber الخاص بـ HandCash
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
