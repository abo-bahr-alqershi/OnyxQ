using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationPeriod Entity
/// </summary>
public class StationPeriod : Entity<StationPeriodId>
{
    private StationPeriod() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: StationPeriod to StationCounterEmployee
    /// </summary>
    public IReadOnlyCollection<StationCounterEmployee> StationCounterEmployees { get; private set; }
    /// <summary>
    /// One-to-many relationship: StationPeriod to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    /// <summary>
    /// One-to-many relationship: StationPeriod to StationCounter
    /// </summary>
    public IReadOnlyCollection<StationCounter> StationCounters { get; private set; }
    #endregion
}
}
