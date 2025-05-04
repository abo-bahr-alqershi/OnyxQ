using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// PeriodExchangeRateDay Entity
/// </summary>
public class PeriodExchangeRateDay : Entity<PeriodExchangeRateDayId>
{
    private PeriodExchangeRateDay() { }

    /// <summary>
    /// The unique identifier for the PeriodExchangeRateDay
    /// المعرف الفريد لـ PeriodExchangeRateDay
    /// </summary>
    public PeriodExchangeRateDayId Id { get; private set; }

    /// <summary>
    /// FDate of the PeriodExchangeRateDay
    /// FDate الخاص بـ PeriodExchangeRateDay
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the PeriodExchangeRateDay
    /// TDate الخاص بـ PeriodExchangeRateDay
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the PeriodExchangeRateDay
    /// AccountCurrency الخاص بـ PeriodExchangeRateDay
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CurRate of the PeriodExchangeRateDay
    /// CurRate الخاص بـ PeriodExchangeRateDay
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// BranchNumber of the PeriodExchangeRateDay
    /// BranchNumber الخاص بـ PeriodExchangeRateDay
    /// </summary>
    public decimal? BranchNumber { get; private set; }
}
}
