using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorClaimMaster Entity
/// </summary>
public class VendorClaimMaster : Entity<VendorClaimMasterId>
{

    private VendorClaimMaster() { }

    public VendorClaimMaster(VendorClaimMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the VendorClaimMaster
    /// المعرف الفريد لـ VendorClaimMaster
    /// </summary>
    public VendorClaimMasterId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the VendorClaimMaster
    /// BranchNumber الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the VendorClaimMaster
    /// DocNo الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the VendorClaimMaster
    /// DocSer الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the VendorClaimMaster
    /// DocDate الخاص بـ VendorClaimMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// VendorCode of the VendorClaimMaster
    /// VendorCode الخاص بـ VendorClaimMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorClaimMaster
    /// AccountCurrency الخاص بـ VendorClaimMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDate of the VendorClaimMaster
    /// FDate الخاص بـ VendorClaimMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the VendorClaimMaster
    /// TDate الخاص بـ VendorClaimMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the VendorClaimMaster
    /// ReferenceNumber الخاص بـ VendorClaimMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the VendorClaimMaster
    /// DocDsc الخاص بـ VendorClaimMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the VendorClaimMaster
    /// ProcessedFlagFull الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// DocAmt of the VendorClaimMaster
    /// DocAmt الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// BranchUser of the VendorClaimMaster
    /// BranchUser الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the VendorClaimMaster
    /// BranchYear الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the VendorClaimMaster
    /// CompanyNumberShort الخاص بـ VendorClaimMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

