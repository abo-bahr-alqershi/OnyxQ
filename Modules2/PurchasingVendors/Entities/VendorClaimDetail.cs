using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorClaimDetail Entity
/// </summary>
public class VendorClaimDetail : Entity<VendorClaimDetailId>
{

    private VendorClaimDetail() { }

    public VendorClaimDetail(VendorClaimDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the VendorClaimDetail
    /// المعرف الفريد لـ VendorClaimDetail
    /// </summary>
    public VendorClaimDetailId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the VendorClaimDetail
    /// BranchNumber الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the VendorClaimDetail
    /// DocNo الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// BillNumber of the VendorClaimDetail
    /// BillNumber الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the VendorClaimDetail
    /// BillSerial الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillType of the VendorClaimDetail
    /// BillType الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? BillType { get; private set; }

    /// <summary>
    /// BillDate of the VendorClaimDetail
    /// BillDate الخاص بـ VendorClaimDetail
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillAmount of the VendorClaimDetail
    /// BillAmount الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// DiscAmt of the VendorClaimDetail
    /// DiscAmt الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// NetAmount of the VendorClaimDetail
    /// NetAmount الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? NetAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the VendorClaimDetail
    /// OtherAmount الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the VendorClaimDetail
    /// VatAmount الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// NetBillAmount of the VendorClaimDetail
    /// NetBillAmount الخاص بـ VendorClaimDetail
    /// </summary>
    public decimal? NetBillAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VendorClaimMaster VendorClaimMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

