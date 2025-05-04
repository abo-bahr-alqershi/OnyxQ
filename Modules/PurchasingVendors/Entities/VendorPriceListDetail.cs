using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorPriceListDetail Entity
/// </summary>
public class VendorPriceListDetail : Entity<VendorPriceListDetailId>
{
    private VendorPriceListDetail() { }

    /// <summary>
    /// The unique identifier for the VendorPriceListDetail
    /// المعرف الفريد لـ VendorPriceListDetail
    /// </summary>
    public VendorPriceListDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the VendorPriceListDetail
    /// DocNo الخاص بـ VendorPriceListDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ItemCode of the VendorPriceListDetail
    /// ItemCode الخاص بـ VendorPriceListDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the VendorPriceListDetail
    /// ItemUnit الخاص بـ VendorPriceListDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorPriceListDetail
    /// AccountCurrency الخاص بـ VendorPriceListDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// VendorPrice of the VendorPriceListDetail
    /// VendorPrice الخاص بـ VendorPriceListDetail
    /// </summary>
    public decimal? VendorPrice { get; private set; }

    /// <summary>
    /// ItemCodeVendor of the VendorPriceListDetail
    /// ItemCodeVendor الخاص بـ VendorPriceListDetail
    /// </summary>
    public string ItemCodeVendor { get; private set; }

    /// <summary>
    /// DocDesc of the VendorPriceListDetail
    /// DocDesc الخاص بـ VendorPriceListDetail
    /// </summary>
    public string DocDesc { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to VendorPriceListMaster
    /// </summary>
    public VendorPriceListMaster VendorPriceListMaster { get; private set; }
    #endregion
}
}
