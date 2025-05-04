using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CouponDetail Entity
/// </summary>
public class CouponDetail : Entity<CouponDetailId>
{

    private CouponDetail() { }

    public CouponDetail(CouponDetailId id, string couponNumber)
    {
        Id = id;
        CouponNumber = couponNumber;
    }

    /// <summary>
    /// The unique identifier for the CouponDetail
    /// المعرف الفريد لـ CouponDetail
    /// </summary>
    public CouponDetailId Id { get; private set; }

    /// <summary>
    /// CouponTypeNumber of the CouponDetail
    /// CouponTypeNumber الخاص بـ CouponDetail
    /// </summary>
    public decimal? CouponTypeNumber { get; private set; }

    /// <summary>
    /// CouponBookNumber of the CouponDetail
    /// CouponBookNumber الخاص بـ CouponDetail
    /// </summary>
    public string CouponBookNumber { get; private set; }

    /// <summary>
    /// CouponNumber of the CouponDetail
    /// CouponNumber الخاص بـ CouponDetail
    /// </summary>
    public string CouponNumber { get; private set; }

    /// <summary>
    /// ItemPriceShort of the CouponDetail
    /// ItemPriceShort الخاص بـ CouponDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// CouponDescriptionDocument of the CouponDetail
    /// CouponDescriptionDocument الخاص بـ CouponDetail
    /// </summary>
    public string CouponDescriptionDocument { get; private set; }

    /// <summary>
    /// ProcessedFlag of the CouponDetail
    /// ProcessedFlag الخاص بـ CouponDetail
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// DocSeq of the CouponDetail
    /// DocSeq الخاص بـ CouponDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// CouponSerial of the CouponDetail
    /// CouponSerial الخاص بـ CouponDetail
    /// </summary>
    public decimal? CouponSerial { get; private set; }

    /// <summary>
    /// InactiveFlag of the CouponDetail
    /// InactiveFlag الخاص بـ CouponDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CouponDetail
    /// InactiveReason الخاص بـ CouponDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CouponDetail
    /// InactiveDate الخاص بـ CouponDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CouponDetail
    /// InactivatedByUserId الخاص بـ CouponDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// SalaryFlag of the CouponDetail
    /// SalaryFlag الخاص بـ CouponDetail
    /// </summary>
    public decimal? SalaryFlag { get; private set; }

    /// <summary>
    /// IssueDate of the CouponDetail
    /// IssueDate الخاص بـ CouponDetail
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// ExpenseDate of the CouponDetail
    /// ExpenseDate الخاص بـ CouponDetail
    /// </summary>
    public DateTime? ExpenseDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the CouponDetail
    /// ItemQuantity الخاص بـ CouponDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the CouponDetail
    /// RecordNumber الخاص بـ CouponDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DstrFlg of the CouponDetail
    /// DstrFlg الخاص بـ CouponDetail
    /// </summary>
    public decimal? DstrFlg { get; private set; }

    /// <summary>
    /// DisPer of the CouponDetail
    /// DisPer الخاص بـ CouponDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CouponMaster CouponMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
