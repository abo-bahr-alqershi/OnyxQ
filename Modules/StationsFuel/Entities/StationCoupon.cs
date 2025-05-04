using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCoupon Entity
/// </summary>
public class StationCoupon : Entity<StationCouponId>
{
    private StationCoupon() { }

    /// <summary>
    /// The unique identifier for the StationCoupon
    /// المعرف الفريد لـ StationCoupon
    /// </summary>
    public StationCouponId Id { get; private set; }

    /// <summary>
    /// CouponNumber of the StationCoupon
    /// CouponNumber الخاص بـ StationCoupon
    /// </summary>
    public decimal? CouponNumber { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationCoupon
    /// FuelTypeNumber الخاص بـ StationCoupon
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// Unit of the StationCoupon
    /// Unit الخاص بـ StationCoupon
    /// </summary>
    public string Unit { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationCoupon
    /// ItemQuantity الخاص بـ StationCoupon
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// IssueDate of the StationCoupon
    /// IssueDate الخاص بـ StationCoupon
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// ExpireDate of the StationCoupon
    /// ExpireDate الخاص بـ StationCoupon
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// SalaryFlag of the StationCoupon
    /// SalaryFlag الخاص بـ StationCoupon
    /// </summary>
    public decimal? SalaryFlag { get; private set; }

    /// <summary>
    /// ProcessedFlag of the StationCoupon
    /// ProcessedFlag الخاص بـ StationCoupon
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the StationCoupon
    /// InactiveFlag الخاص بـ StationCoupon
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the StationCoupon
    /// InactivatedByUserId الخاص بـ StationCoupon
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the StationCoupon
    /// InactiveDate الخاص بـ StationCoupon
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the StationCoupon
    /// InactiveReason الخاص بـ StationCoupon
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// MoveCouponPaymentYear of the StationCoupon
    /// MoveCouponPaymentYear الخاص بـ StationCoupon
    /// </summary>
    public decimal? MoveCouponPaymentYear { get; private set; }

    /// <summary>
    /// CouponNumberPaymentYear of the StationCoupon
    /// CouponNumberPaymentYear الخاص بـ StationCoupon
    /// </summary>
    public decimal? CouponNumberPaymentYear { get; private set; }

    /// <summary>
    /// CouponSerialPaymentYear of the StationCoupon
    /// CouponSerialPaymentYear الخاص بـ StationCoupon
    /// </summary>
    public decimal? CouponSerialPaymentYear { get; private set; }

    /// <summary>
    /// CreatedDatePayment of the StationCoupon
    /// CreatedDatePayment الخاص بـ StationCoupon
    /// </summary>
    public DateTime? CreatedDatePayment { get; private set; }

    /// <summary>
    /// CouponSerial of the StationCoupon
    /// CouponSerial الخاص بـ StationCoupon
    /// </summary>
    public decimal? CouponSerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: StationCoupon to StationCouponSalesDetail
    /// </summary>
    public IReadOnlyCollection<StationCouponSalesDetail> StationCouponSalesDetails { get; private set; }
    #endregion
}
}
