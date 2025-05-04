using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorItem Entity
/// </summary>
public class VendorItem : Entity<VendorItemId>
{
    private VendorItem() { }

    /// <summary>
    /// The unique identifier for the VendorItem
    /// المعرف الفريد لـ VendorItem
    /// </summary>
    public VendorItemId Id { get; private set; }

    /// <summary>
    /// ItemCode of the VendorItem
    /// ItemCode الخاص بـ VendorItem
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// VendorCode of the VendorItem
    /// VendorCode الخاص بـ VendorItem
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ItemPacking of the VendorItem
    /// ItemPacking الخاص بـ VendorItem
    /// </summary>
    public decimal? ItemPacking { get; private set; }

    /// <summary>
    /// VendorPrice of the VendorItem
    /// VendorPrice الخاص بـ VendorItem
    /// </summary>
    public decimal? VendorPrice { get; private set; }

    /// <summary>
    /// MainVendor of the VendorItem
    /// MainVendor الخاص بـ VendorItem
    /// </summary>
    public decimal? MainVendor { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorItem
    /// AccountCurrency الخاص بـ VendorItem
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// ItemUnit of the VendorItem
    /// ItemUnit الخاص بـ VendorItem
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the VendorItem
    /// PSize الخاص بـ VendorItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemCodeVendor of the VendorItem
    /// ItemCodeVendor الخاص بـ VendorItem
    /// </summary>
    public string ItemCodeVendor { get; private set; }

    /// <summary>
    /// UnitVendor of the VendorItem
    /// UnitVendor الخاص بـ VendorItem
    /// </summary>
    public string UnitVendor { get; private set; }

    /// <summary>
    /// ItemMinQuantity of the VendorItem
    /// ItemMinQuantity الخاص بـ VendorItem
    /// </summary>
    public decimal? ItemMinQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion
}
}
