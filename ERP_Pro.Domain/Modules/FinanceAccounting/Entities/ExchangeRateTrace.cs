using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ExchangeRateTrace Entity
/// </summary>
public class ExchangeRateTrace : Entity<ExchangeRateTraceId>
{

    private ExchangeRateTrace() { }

    public ExchangeRateTrace(ExchangeRateTraceId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ExchangeRateTrace
    /// المعرف الفريد لـ ExchangeRateTrace
    /// </summary>
    public ExchangeRateTraceId Id { get; private set; }

    /// <summary>
    /// CurNo of the ExchangeRateTrace
    /// CurNo الخاص بـ ExchangeRateTrace
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// CurCode of the ExchangeRateTrace
    /// CurCode الخاص بـ ExchangeRateTrace
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the ExchangeRateTrace
    /// CurRate الخاص بـ ExchangeRateTrace
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// MaxCurrencyRate of the ExchangeRateTrace
    /// MaxCurrencyRate الخاص بـ ExchangeRateTrace
    /// </summary>
    public decimal? MaxCurrencyRate { get; private set; }

    /// <summary>
    /// MinCurrencyRate of the ExchangeRateTrace
    /// MinCurrencyRate الخاص بـ ExchangeRateTrace
    /// </summary>
    public decimal? MinCurrencyRate { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
