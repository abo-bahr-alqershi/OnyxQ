using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorLimitPurchase Entity
/// </summary>
public class VendorLimitPurchase : Entity<VendorLimitPurchaseId>
{

    private VendorLimitPurchase() { }

    public VendorLimitPurchase(VendorLimitPurchaseId id, string accountCurrency, DateTime? fDate, DateTime? tDate)
    {
        Id = id;
        AccountCurrency = accountCurrency;
        FDate = fDate;
        TDate = tDate;
    }

    /// <summary>
    /// The unique identifier for the VendorLimitPurchase
    /// المعرف الفريد لـ VendorLimitPurchase
    /// </summary>
    public VendorLimitPurchaseId Id { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorLimitPurchase
    /// AccountCurrency الخاص بـ VendorLimitPurchase
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDate of the VendorLimitPurchase
    /// FDate الخاص بـ VendorLimitPurchase
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the VendorLimitPurchase
    /// TDate الخاص بـ VendorLimitPurchase
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// Amount of the VendorLimitPurchase
    /// Amount الخاص بـ VendorLimitPurchase
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// LimitDescriptionShort of the VendorLimitPurchase
    /// LimitDescriptionShort الخاص بـ VendorLimitPurchase
    /// </summary>
    public string LimitDescriptionShort { get; private set; }

    /// <summary>
    /// RecordNumber of the VendorLimitPurchase
    /// RecordNumber الخاص بـ VendorLimitPurchase
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

