using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CouponTypeDetail Entity
/// </summary>
public class CouponTypeDetail : Entity<CouponTypeDetailId>
{
    private CouponTypeDetail() { }

    /// <summary>
    /// The unique identifier for the CouponTypeDetail
    /// المعرف الفريد لـ CouponTypeDetail
    /// </summary>
    public CouponTypeDetailId Id { get; private set; }

    /// <summary>
    /// CouponTypeNumber of the CouponTypeDetail
    /// CouponTypeNumber الخاص بـ CouponTypeDetail
    /// </summary>
    public decimal? CouponTypeNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the CouponTypeDetail
    /// RecordNumber الخاص بـ CouponTypeDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the CouponTypeDetail
    /// ItemCode الخاص بـ CouponTypeDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the CouponTypeDetail
    /// ItemUnit الخاص بـ CouponTypeDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to CouponTypeMaster
    /// </summary>
    public CouponTypeMaster CouponTypeMaster { get; private set; }
    #endregion
}
}
