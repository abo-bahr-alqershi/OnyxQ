using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationBillCoupon Entity
/// </summary>
public class StationBillCoupon : Entity<StationBillCouponId>
{
    private readonly List<StationBillMaster> _stationBillMaster = new List<StationBillMaster>();
    private readonly List<StationFuelType> _stationFuelType = new List<StationFuelType>();

    private StationBillCoupon() { }

    public StationBillCoupon(StationBillCouponId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the StationBillCoupon
    /// المعرف الفريد لـ StationBillCoupon
    /// </summary>
    public StationBillCouponId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationBillCoupon
    /// DocNo الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CouponNumber of the StationBillCoupon
    /// CouponNumber الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? CouponNumber { get; private set; }

    /// <summary>
    /// CCode of the StationBillCoupon
    /// CCode الخاص بـ StationBillCoupon
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationBillCoupon
    /// ItemQuantity الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationBillCoupon
    /// ItemPriceShort الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// IssueDate of the StationBillCoupon
    /// IssueDate الخاص بـ StationBillCoupon
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// ExpireDate of the StationBillCoupon
    /// ExpireDate الخاص بـ StationBillCoupon
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// CouponDescription of the StationBillCoupon
    /// CouponDescription الخاص بـ StationBillCoupon
    /// </summary>
    public string CouponDescription { get; private set; }

    /// <summary>
    /// BatchNumber of the StationBillCoupon
    /// BatchNumber الخاص بـ StationBillCoupon
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DisPer of the StationBillCoupon
    /// DisPer الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the StationBillCoupon
    /// DisAmt الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the StationBillCoupon
    /// DiscAmtMst الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// EmpNo of the StationBillCoupon
    /// EmpNo الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ItemCode of the StationBillCoupon
    /// ItemCode الخاص بـ StationBillCoupon
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationBillCoupon
    /// WarehouseCode الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CuntrNo of the StationBillCoupon
    /// CuntrNo الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// RecordNumber of the StationBillCoupon
    /// RecordNumber الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationBillCoupon
    /// CostCenterCode الخاص بـ StationBillCoupon
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationBillCoupon
    /// ProjectNumber الخاص بـ StationBillCoupon
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationBillCoupon
    /// ActivityNumber الخاص بـ StationBillCoupon
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// VatAmount of the StationBillCoupon
    /// VatAmount الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the StationBillCoupon
    /// VatPercent الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationBillCoupon
    /// CompanyNumberShort الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationBillCoupon
    /// BranchNumber الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationBillCoupon
    /// BranchYear الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationBillCoupon
    /// BranchUser الخاص بـ StationBillCoupon
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<StationBillMaster> StationBillMaster => _stationBillMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<StationFuelType> StationFuelType => _stationFuelType;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
