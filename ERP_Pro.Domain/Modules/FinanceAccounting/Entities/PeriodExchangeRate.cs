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

    public PeriodExchangeRate(PeriodExchangeRateId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PeriodExchangeRate
    /// المعرف الفريد لـ PeriodExchangeRate
    /// </summary>
    public PeriodExchangeRateId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public PeriodDetail PeriodDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
