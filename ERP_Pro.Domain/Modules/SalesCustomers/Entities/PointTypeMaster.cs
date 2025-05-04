using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PointTypeMaster Entity
/// </summary>
public class PointTypeMaster : Entity<PointTypeMasterId>
{

    private PointTypeMaster() { }

    public PointTypeMaster(PointTypeMasterId id, decimal? pointTypeNumber)
    {
        Id = id;
        PointTypeNumber = pointTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the PointTypeMaster
    /// المعرف الفريد لـ PointTypeMaster
    /// </summary>
    public PointTypeMasterId Id { get; private set; }

    /// <summary>
    /// PointTypeNumber of the PointTypeMaster
    /// PointTypeNumber الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// TypeLastNameShort of the PointTypeMaster
    /// TypeLastNameShort الخاص بـ PointTypeMaster
    /// </summary>
    public string TypeLastNameShort { get; private set; }

    /// <summary>
    /// TypeFirstNameShort of the PointTypeMaster
    /// TypeFirstNameShort الخاص بـ PointTypeMaster
    /// </summary>
    public string TypeFirstNameShort { get; private set; }

    /// <summary>
    /// StartDate of the PointTypeMaster
    /// StartDate الخاص بـ PointTypeMaster
    /// </summary>
    public DateTime? StartDate { get; private set; }

    /// <summary>
    /// EndDate of the PointTypeMaster
    /// EndDate الخاص بـ PointTypeMaster
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// PointCalculationType of the PointTypeMaster
    /// PointCalculationType الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? PointCalculationType { get; private set; }

    /// <summary>
    /// MinLimitCalculation of the PointTypeMaster
    /// MinLimitCalculation الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? MinLimitCalculation { get; private set; }

    /// <summary>
    /// MinLimitReplace of the PointTypeMaster
    /// MinLimitReplace الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? MinLimitReplace { get; private set; }

    /// <summary>
    /// AmountFourPoint of the PointTypeMaster
    /// AmountFourPoint الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? AmountFourPoint { get; private set; }

    /// <summary>
    /// AmountFourPointReplace of the PointTypeMaster
    /// AmountFourPointReplace الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? AmountFourPointReplace { get; private set; }

    /// <summary>
    /// PointCount of the PointTypeMaster
    /// PointCount الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// PointCountReplace of the PointTypeMaster
    /// PointCountReplace الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? PointCountReplace { get; private set; }

    /// <summary>
    /// InactiveFlag of the PointTypeMaster
    /// InactiveFlag الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the PointTypeMaster
    /// InactiveReason الخاص بـ PointTypeMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the PointTypeMaster
    /// InactiveDate الخاص بـ PointTypeMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// PointAmountCalculationType of the PointTypeMaster
    /// PointAmountCalculationType الخاص بـ PointTypeMaster
    /// </summary>
    public decimal? PointAmountCalculationType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
