using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CloseDayPeriods Entity
/// </summary>
public class CloseDayPeriods : Entity<CloseDayPeriodsId>
{
    private CloseDayPeriods() { }

    /// <summary>
    /// The unique identifier for the CloseDayPeriods
    /// المعرف الفريد لـ CloseDayPeriods
    /// </summary>
    public CloseDayPeriodsId Id { get; private set; }

    /// <summary>
    /// FDate of the CloseDayPeriods
    /// FDate الخاص بـ CloseDayPeriods
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CloseDayPeriods
    /// TDate الخاص بـ CloseDayPeriods
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the CloseDayPeriods
    /// PeriodNumberShort الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// YearNumber of the CloseDayPeriods
    /// YearNumber الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? YearNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the CloseDayPeriods
    /// BranchNumber الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// Status of the CloseDayPeriods
    /// Status الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? Status { get; private set; }

    /// <summary>
    /// PeriodCloseUserId of the CloseDayPeriods
    /// PeriodCloseUserId الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? PeriodCloseUserId { get; private set; }

    /// <summary>
    /// PeriodCloseDate of the CloseDayPeriods
    /// PeriodCloseDate الخاص بـ CloseDayPeriods
    /// </summary>
    public DateTime? PeriodCloseDate { get; private set; }

    /// <summary>
    /// PeriodUncloseUserId of the CloseDayPeriods
    /// PeriodUncloseUserId الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? PeriodUncloseUserId { get; private set; }

    /// <summary>
    /// PeriodUncloseDate of the CloseDayPeriods
    /// PeriodUncloseDate الخاص بـ CloseDayPeriods
    /// </summary>
    public DateTime? PeriodUncloseDate { get; private set; }

    /// <summary>
    /// PeriodCloseCount of the CloseDayPeriods
    /// PeriodCloseCount الخاص بـ CloseDayPeriods
    /// </summary>
    public decimal? PeriodCloseCount { get; private set; }
}
}
