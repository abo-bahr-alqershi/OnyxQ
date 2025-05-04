using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorPriceListMaster Entity
/// </summary>
public class VendorPriceListMaster : Entity<VendorPriceListMasterId>
{

    private VendorPriceListMaster() { }

    public VendorPriceListMaster(VendorPriceListMasterId id, decimal? docNo)
    {
        Id = id;
        DocNo = docNo;
    }

    /// <summary>
    /// The unique identifier for the VendorPriceListMaster
    /// المعرف الفريد لـ VendorPriceListMaster
    /// </summary>
    public VendorPriceListMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the VendorPriceListMaster
    /// DocNo الخاص بـ VendorPriceListMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the VendorPriceListMaster
    /// DocDate الخاص بـ VendorPriceListMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// VendorCode of the VendorPriceListMaster
    /// VendorCode الخاص بـ VendorPriceListMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorPriceListMaster
    /// AccountCurrency الخاص بـ VendorPriceListMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocDesc of the VendorPriceListMaster
    /// DocDesc الخاص بـ VendorPriceListMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the VendorPriceListMaster
    /// ReferenceNumber الخاص بـ VendorPriceListMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
