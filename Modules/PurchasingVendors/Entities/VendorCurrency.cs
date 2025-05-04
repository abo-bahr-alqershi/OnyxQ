using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorCurrency Entity
/// </summary>
public class VendorCurrency : Entity<VendorCurrencyId>
{
    private VendorCurrency() { }

    /// <summary>
    /// The unique identifier for the VendorCurrency
    /// المعرف الفريد لـ VendorCurrency
    /// </summary>
    public VendorCurrencyId Id { get; private set; }

    /// <summary>
    /// VendorCode of the VendorCurrency
    /// VendorCode الخاص بـ VendorCurrency
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorCurrency
    /// AccountCurrency الخاص بـ VendorCurrency
    /// </summary>
    public string AccountCurrency { get; private set; }

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
    /// One-to-many relationship: VendorCurrency to PrivilegeVendor
    /// </summary>
    public IReadOnlyCollection<PrivilegeVendor> PrivilegeVendors { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: VendorCurrency to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
