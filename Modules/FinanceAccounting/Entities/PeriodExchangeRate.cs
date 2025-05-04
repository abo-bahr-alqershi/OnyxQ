using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// PeriodExchangeRate Entity
/// </summary>
public class PeriodExchangeRate : Entity<PeriodExchangeRateId>
{
    private PeriodExchangeRate() { }

    /// <summary>
    /// The unique identifier for the PeriodExchangeRate
    /// المعرف الفريد لـ PeriodExchangeRate
    /// </summary>
    public PeriodExchangeRateId Id { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the PeriodExchangeRate
    /// PeriodNumberShort الخاص بـ PeriodExchangeRate
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// AccountCurrency of the PeriodExchangeRate
    /// AccountCurrency الخاص بـ PeriodExchangeRate
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CurRate of the PeriodExchangeRate
    /// CurRate الخاص بـ PeriodExchangeRate
    /// </summary>
    public decimal? CurRate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to PeriodDetail
    /// </summary>
    public PeriodDetail PeriodDetail { get; private set; }
    #endregion
}
}
