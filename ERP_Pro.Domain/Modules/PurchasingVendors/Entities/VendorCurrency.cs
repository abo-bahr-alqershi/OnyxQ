using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorCurrency Entity
/// </summary>
public class VendorCurrency : Entity<VendorCurrencyId>
{

    private VendorCurrency() { }

    public VendorCurrency(VendorCurrencyId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the VendorCurrency
    /// المعرف الفريد لـ VendorCurrency
    /// </summary>
    public VendorCurrencyId Id { get; private set; }

    /// <summary>
    /// InactiveFlag of the VendorCurrency
    /// InactiveFlag الخاص بـ VendorCurrency
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// MaxLimitAmountPurchaseRequest of the VendorCurrency
    /// MaxLimitAmountPurchaseRequest الخاص بـ VendorCurrency
    /// </summary>
    public decimal? MaxLimitAmountPurchaseRequest { get; private set; }

    /// <summary>
    /// MaxLimitAmountPurchaseOrder of the VendorCurrency
    /// MaxLimitAmountPurchaseOrder الخاص بـ VendorCurrency
    /// </summary>
    public decimal? MaxLimitAmountPurchaseOrder { get; private set; }

    /// <summary>
    /// CurDflt of the VendorCurrency
    /// CurDflt الخاص بـ VendorCurrency
    /// </summary>
    public decimal? CurDflt { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
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
