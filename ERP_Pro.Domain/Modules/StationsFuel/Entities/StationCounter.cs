using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCounter Entity
/// </summary>
public class StationCounter : Entity<StationCounterId>
{

    private StationCounter() { }

    public StationCounter(StationCounterId id, decimal? cuntrNo)
    {
        Id = id;
        CuntrNo = cuntrNo;
    }

    /// <summary>
    /// The unique identifier for the StationCounter
    /// المعرف الفريد لـ StationCounter
    /// </summary>
    public StationCounterId Id { get; private set; }

    /// <summary>
    /// CuntrNo of the StationCounter
    /// CuntrNo الخاص بـ StationCounter
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// CuntrLNm of the StationCounter
    /// CuntrLNm الخاص بـ StationCounter
    /// </summary>
    public string CuntrLNm { get; private set; }

    /// <summary>
    /// CuntrFNm of the StationCounter
    /// CuntrFNm الخاص بـ StationCounter
    /// </summary>
    public string CuntrFNm { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationCounter
    /// WarehouseCode الخاص بـ StationCounter
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// PrimaryRead of the StationCounter
    /// PrimaryRead الخاص بـ StationCounter
    /// </summary>
    public decimal? PrimaryRead { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCounter
    /// BranchNumber الخاص بـ StationCounter
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the StationCounter
    /// InactiveFlag الخاص بـ StationCounter
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the StationCounter
    /// InactiveDate الخاص بـ StationCounter
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the StationCounter
    /// InactiveReason الخاص بـ StationCounter
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the StationCounter
    /// InactivatedByUserId الخاص بـ StationCounter
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CuntrCode of the StationCounter
    /// CuntrCode الخاص بـ StationCounter
    /// </summary>
    public string CuntrCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationCounter
    /// CostCenterCode الخاص بـ StationCounter
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationCounter
    /// ProjectNumber الخاص بـ StationCounter
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationCounter
    /// ActivityNumber الخاص بـ StationCounter
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public StationFuelType StationFuelType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
