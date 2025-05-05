using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorItem Entity
/// </summary>
public class VendorItem : Entity<VendorItemId>
{

    private VendorItem() { }

    public VendorItem(VendorItemId id, string itemCode, string itemUnit)
    {
        Id = id;
        ItemCode = itemCode;
        ItemUnit = itemUnit;
    }

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

