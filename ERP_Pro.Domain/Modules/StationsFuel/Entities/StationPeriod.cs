using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;
namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationPeriod Entity
/// </summary>
public class StationPeriod : Entity<StationPeriodId>
{

    private StationPeriod() { }

    public StationPeriod(StationPeriodId id, decimal? periodNumberShort)
    {
        Id = id;
        PeriodNumberShort = periodNumberShort;
    }

    /// <summary>
    /// The unique identifier for the StationPeriod
    /// المعرف الفريد لـ StationPeriod
    /// </summary>
    public StationPeriodId Id { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the StationPeriod
    /// PeriodNumberShort الخاص بـ StationPeriod
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// PeriodNameArabic of the StationPeriod
    /// PeriodNameArabic الخاص بـ StationPeriod
    /// </summary>
    public string PeriodNameArabic { get; private set; }

    /// <summary>
    /// PeriodFirstName of the StationPeriod
    /// PeriodFirstName الخاص بـ StationPeriod
    /// </summary>
    public string PeriodFirstName { get; private set; }

    /// <summary>
    /// FTime of the StationPeriod
    /// FTime الخاص بـ StationPeriod
    /// </summary>
    public string FTime { get; private set; }

    /// <summary>
    /// TTime of the StationPeriod
    /// TTime الخاص بـ StationPeriod
    /// </summary>
    public string TTime { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

