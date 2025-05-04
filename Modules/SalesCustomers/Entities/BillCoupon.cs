using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BillCoupon Entity
/// </summary>
public class BillCoupon : Entity<BillCouponId>
{
    private BillCoupon() { }

    /// <summary>
    /// The unique identifier for the BillCoupon
    /// المعرف الفريد لـ BillCoupon
    /// </summary>
    public BillCouponId Id { get; private set; }

    /// <summary>
    /// BillNumber of the BillCoupon
    /// BillNumber الخاص بـ BillCoupon
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BillCoupon
    /// BillSerial الخاص بـ BillCoupon
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// CouponTypeNumber of the BillCoupon
    /// CouponTypeNumber الخاص بـ BillCoupon
    /// </summary>
    public decimal? CouponTypeNumber { get; private set; }

    /// <summary>
    /// CouponBookNumber of the BillCoupon
    /// CouponBookNumber الخاص بـ BillCoupon
    /// </summary>
    public string CouponBookNumber { get; private set; }

    /// <summary>
    /// CouponNumber of the BillCoupon
    /// CouponNumber الخاص بـ BillCoupon
    /// </summary>
    public string CouponNumber { get; private set; }

    /// <summary>
    /// CouponAmount of the BillCoupon
    /// CouponAmount الخاص بـ BillCoupon
    /// </summary>
    public decimal? CouponAmount { get; private set; }

    /// <summary>
    /// CouponDescription of the BillCoupon
    /// CouponDescription الخاص بـ BillCoupon
    /// </summary>
    public string CouponDescription { get; private set; }

    /// <summary>
    /// RepCode of the BillCoupon
    /// RepCode الخاص بـ BillCoupon
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// RecordNumber of the BillCoupon
    /// RecordNumber الخاص بـ BillCoupon
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSeq of the BillCoupon
    /// DocSeq الخاص بـ BillCoupon
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// ItemQuantity of the BillCoupon
    /// ItemQuantity الخاص بـ BillCoupon
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// CostCenterCode of the BillCoupon
    /// CostCenterCode الخاص بـ BillCoupon
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BillCoupon
    /// ProjectNumber الخاص بـ BillCoupon
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BillCoupon
    /// ActivityNumber الخاص بـ BillCoupon
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BillCoupon
    /// CompanyNumberShort الخاص بـ BillCoupon
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BillCoupon
    /// BranchNumber الخاص بـ BillCoupon
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BillCoupon
    /// BranchYear الخاص بـ BillCoupon
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BillCoupon
    /// BranchUser الخاص بـ BillCoupon
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to BillMaster
    /// </summary>
    public BillMaster BillMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion
}
}
