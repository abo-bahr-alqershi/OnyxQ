using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableDiscount Entity
/// </summary>
public class AccountsPayableDiscount : Entity<AccountsPayableDiscountId>
{
    private AccountsPayableDiscount() { }

    /// <summary>
    /// The unique identifier for the AccountsPayableDiscount
    /// المعرف الفريد لـ AccountsPayableDiscount
    /// </summary>
    public AccountsPayableDiscountId Id { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableDiscount
    /// VendorCode الخاص بـ AccountsPayableDiscount
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsPayableDiscount
    /// ItemCode الخاص بـ AccountsPayableDiscount
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableDiscount
    /// ItemUnit الخاص بـ AccountsPayableDiscount
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableDiscount
    /// PSize الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AmountType of the AccountsPayableDiscount
    /// AmountType الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableDiscount
    /// Amount الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// Amount2 of the AccountsPayableDiscount
    /// Amount2 الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? Amount2 { get; private set; }

    /// <summary>
    /// Amount3 of the AccountsPayableDiscount
    /// Amount3 الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? Amount3 { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountsPayableDiscount
    /// AccountCurrency الخاص بـ AccountsPayableDiscount
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the AccountsPayableDiscount
    /// AccountRate الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// FDate of the AccountsPayableDiscount
    /// FDate الخاص بـ AccountsPayableDiscount
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the AccountsPayableDiscount
    /// TDate الخاص بـ AccountsPayableDiscount
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// LastNumber of the AccountsPayableDiscount
    /// LastNumber الخاص بـ AccountsPayableDiscount
    /// </summary>
    public decimal? LastNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion
}
}
