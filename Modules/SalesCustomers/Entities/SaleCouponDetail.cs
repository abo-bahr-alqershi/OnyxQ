using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SaleCouponDetail Entity
/// </summary>
public class SaleCouponDetail : Entity<SaleCouponDetailId>
{
    private SaleCouponDetail() { }

    /// <summary>
    /// The unique identifier for the SaleCouponDetail
    /// المعرف الفريد لـ SaleCouponDetail
    /// </summary>
    public SaleCouponDetailId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SaleCouponDetail
    /// BillDocumentTypeFull الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the SaleCouponDetail
    /// DocNo الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the SaleCouponDetail
    /// DocSer الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// RecordNumber of the SaleCouponDetail
    /// RecordNumber الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CouponBookNumber of the SaleCouponDetail
    /// CouponBookNumber الخاص بـ SaleCouponDetail
    /// </summary>
    public string CouponBookNumber { get; private set; }

    /// <summary>
    /// CouponNumber of the SaleCouponDetail
    /// CouponNumber الخاص بـ SaleCouponDetail
    /// </summary>
    public string CouponNumber { get; private set; }

    /// <summary>
    /// CCode of the SaleCouponDetail
    /// CCode الخاص بـ SaleCouponDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the SaleCouponDetail
    /// ItemQuantity الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the SaleCouponDetail
    /// ItemPriceShort الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// CouponDescription of the SaleCouponDetail
    /// CouponDescription الخاص بـ SaleCouponDetail
    /// </summary>
    public string CouponDescription { get; private set; }

    /// <summary>
    /// DocSeq of the SaleCouponDetail
    /// DocSeq الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// ProcessedFlag of the SaleCouponDetail
    /// ProcessedFlag الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// VatPercent of the SaleCouponDetail
    /// VatPercent الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the SaleCouponDetail
    /// VatAmount الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the SaleCouponDetail
    /// InactiveFlag الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the SaleCouponDetail
    /// InactivatedByUserId الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the SaleCouponDetail
    /// InactiveDate الخاص بـ SaleCouponDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the SaleCouponDetail
    /// InactiveReason الخاص بـ SaleCouponDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// CouponType of the SaleCouponDetail
    /// CouponType الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? CouponType { get; private set; }

    /// <summary>
    /// CouponTypeNumber of the SaleCouponDetail
    /// CouponTypeNumber الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? CouponTypeNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SaleCouponDetail
    /// CompanyNumberShort الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SaleCouponDetail
    /// BranchNumber الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SaleCouponDetail
    /// BranchYear الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SaleCouponDetail
    /// BranchUser الخاص بـ SaleCouponDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to SaleCouponMaster
    /// </summary>
    public SaleCouponMaster SaleCouponMaster { get; private set; }
    #endregion
}
}
