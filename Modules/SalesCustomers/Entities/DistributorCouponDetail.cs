using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DistributorCouponDetail Entity
/// </summary>
public class DistributorCouponDetail : Entity<DistributorCouponDetailId>
{
    private DistributorCouponDetail() { }

    /// <summary>
    /// The unique identifier for the DistributorCouponDetail
    /// المعرف الفريد لـ DistributorCouponDetail
    /// </summary>
    public DistributorCouponDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the DistributorCouponDetail
    /// DocType الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the DistributorCouponDetail
    /// DocNo الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DistributorCouponDetail
    /// DocSer الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CouponType of the DistributorCouponDetail
    /// CouponType الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? CouponType { get; private set; }

    /// <summary>
    /// CouponBookNumber of the DistributorCouponDetail
    /// CouponBookNumber الخاص بـ DistributorCouponDetail
    /// </summary>
    public string CouponBookNumber { get; private set; }

    /// <summary>
    /// CouponNumber of the DistributorCouponDetail
    /// CouponNumber الخاص بـ DistributorCouponDetail
    /// </summary>
    public string CouponNumber { get; private set; }

    /// <summary>
    /// CouponDescriptionDocument of the DistributorCouponDetail
    /// CouponDescriptionDocument الخاص بـ DistributorCouponDetail
    /// </summary>
    public string CouponDescriptionDocument { get; private set; }

    /// <summary>
    /// ReturnFlag of the DistributorCouponDetail
    /// ReturnFlag الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? ReturnFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the DistributorCouponDetail
    /// RecordNumber الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSeq of the DistributorCouponDetail
    /// DocSeq الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// BranchNumber of the DistributorCouponDetail
    /// BranchNumber الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DistributorCouponDetail
    /// CompanyNumberShort الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the DistributorCouponDetail
    /// BranchYear الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DistributorCouponDetail
    /// BranchUser الخاص بـ DistributorCouponDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
