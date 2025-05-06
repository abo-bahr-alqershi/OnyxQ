using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableDiscountHistory Entity
/// </summary>
public class AccountsPayableDiscountHistory : Entity<AccountsPayableDiscountHistoryId>
{

    private AccountsPayableDiscountHistory() { }

    public AccountsPayableDiscountHistory(AccountsPayableDiscountHistoryId id, decimal? auditNumber)
    {
        Id = id;
        AuditNumber = auditNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableDiscountHistory
    /// المعرف الفريد لـ AccountsPayableDiscountHistory
    /// </summary>
    public AccountsPayableDiscountHistoryId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the AccountsPayableDiscountHistory
    /// AuditNumber الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the AccountsPayableDiscountHistory
    /// AuditType الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// DocDate of the AccountsPayableDiscountHistory
    /// DocDate الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableDiscountHistory
    /// DocNo الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableDiscountHistory
    /// VendorCode الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsPayableDiscountHistory
    /// ItemCode الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableDiscountHistory
    /// ItemUnit الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableDiscountHistory
    /// PSize الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AmountType of the AccountsPayableDiscountHistory
    /// AmountType الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableDiscountHistory
    /// Amount الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// Amount2 of the AccountsPayableDiscountHistory
    /// Amount2 الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? Amount2 { get; private set; }

    /// <summary>
    /// Amount3 of the AccountsPayableDiscountHistory
    /// Amount3 الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? Amount3 { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountsPayableDiscountHistory
    /// AccountCurrency الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the AccountsPayableDiscountHistory
    /// AccountRate الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// AuditUserId of the AccountsPayableDiscountHistory
    /// AuditUserId الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the AccountsPayableDiscountHistory
    /// AuditDate الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// FDate of the AccountsPayableDiscountHistory
    /// FDate الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the AccountsPayableDiscountHistory
    /// TDate الخاص بـ AccountsPayableDiscountHistory
    /// </summary>
    public DateTime? TDate { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

