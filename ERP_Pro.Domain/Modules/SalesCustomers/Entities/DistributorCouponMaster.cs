using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DistributorCouponMaster Entity
/// </summary>
public class DistributorCouponMaster : Entity<DistributorCouponMasterId>
{

    private DistributorCouponMaster() { }

    public DistributorCouponMaster(DistributorCouponMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the DistributorCouponMaster
    /// المعرف الفريد لـ DistributorCouponMaster
    /// </summary>
    public DistributorCouponMasterId Id { get; private set; }

    /// <summary>
    /// DocType of the DistributorCouponMaster
    /// DocType الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the DistributorCouponMaster
    /// DocNo الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DistributorCouponMaster
    /// DocSer الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the DistributorCouponMaster
    /// DocDate الخاص بـ DistributorCouponMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CouponType of the DistributorCouponMaster
    /// CouponType الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? CouponType { get; private set; }

    /// <summary>
    /// RepCode of the DistributorCouponMaster
    /// RepCode الخاص بـ DistributorCouponMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ReceiptNameShort of the DistributorCouponMaster
    /// ReceiptNameShort الخاص بـ DistributorCouponMaster
    /// </summary>
    public string ReceiptNameShort { get; private set; }

    /// <summary>
    /// ReferenceNumber of the DistributorCouponMaster
    /// ReferenceNumber الخاص بـ DistributorCouponMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the DistributorCouponMaster
    /// DocDsc الخاص بـ DistributorCouponMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the DistributorCouponMaster
    /// ExternalPostFlag الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// Field1 of the DistributorCouponMaster
    /// Field1 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the DistributorCouponMaster
    /// Field2 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the DistributorCouponMaster
    /// Field3 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the DistributorCouponMaster
    /// Field4 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the DistributorCouponMaster
    /// Field5 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the DistributorCouponMaster
    /// Field6 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the DistributorCouponMaster
    /// Field7 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the DistributorCouponMaster
    /// Field8 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the DistributorCouponMaster
    /// Field9 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the DistributorCouponMaster
    /// Field10 الخاص بـ DistributorCouponMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DistributorCouponMaster
    /// CompanyNumberShort الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DistributorCouponMaster
    /// BranchNumber الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DistributorCouponMaster
    /// BranchYear الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DistributorCouponMaster
    /// BranchUser الخاص بـ DistributorCouponMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
