using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCouponSalesDetail Entity
/// </summary>
public class StationCouponSalesDetail : Entity<StationCouponSalesDetailId>
{
    private StationCouponSalesDetail() { }

    /// <summary>
    /// The unique identifier for the StationCouponSalesDetail
    /// المعرف الفريد لـ StationCouponSalesDetail
    /// </summary>
    public StationCouponSalesDetailId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the StationCouponSalesDetail
    /// BillDocumentTypeFull الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the StationCouponSalesDetail
    /// DocNo الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationCouponSalesDetail
    /// DocSer الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationCouponSalesDetail
    /// ItemQuantity الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationCouponSalesDetail
    /// ItemPriceShort الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// VatAmount of the StationCouponSalesDetail
    /// VatAmount الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the StationCouponSalesDetail
    /// VatPercent الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// RecordNumber of the StationCouponSalesDetail
    /// RecordNumber الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationCouponSalesDetail
    /// CompanyNumberShort الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCouponSalesDetail
    /// BranchNumber الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationCouponSalesDetail
    /// BranchYear الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationCouponSalesDetail
    /// BranchUser الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CouponDescription of the StationCouponSalesDetail
    /// CouponDescription الخاص بـ StationCouponSalesDetail
    /// </summary>
    public string CouponDescription { get; private set; }

    /// <summary>
    /// ProcessedFlag of the StationCouponSalesDetail
    /// ProcessedFlag الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the StationCouponSalesDetail
    /// InactiveFlag الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the StationCouponSalesDetail
    /// InactivatedByUserId الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the StationCouponSalesDetail
    /// InactiveDate الخاص بـ StationCouponSalesDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the StationCouponSalesDetail
    /// InactiveReason الخاص بـ StationCouponSalesDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// CouponNumber of the StationCouponSalesDetail
    /// CouponNumber الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? CouponNumber { get; private set; }

    /// <summary>
    /// CCode of the StationCouponSalesDetail
    /// CCode الخاص بـ StationCouponSalesDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationCouponSalesDetail
    /// FuelTypeNumber الخاص بـ StationCouponSalesDetail
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to StationCoupon
    /// </summary>
    public StationCoupon StationCoupon { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationCouponSalesMaster
    /// </summary>
    public StationCouponSalesMaster StationCouponSalesMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationFuelType
    /// </summary>
    public StationFuelType StationFuelType { get; private set; }
    #endregion
}
}
