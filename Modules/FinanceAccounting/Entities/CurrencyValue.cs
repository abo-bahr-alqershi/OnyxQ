using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CurrencyValue Entity
/// </summary>
public class CurrencyValue : Entity<CurrencyValueId>
{
    private CurrencyValue() { }

    /// <summary>
    /// The unique identifier for the CurrencyValue
    /// المعرف الفريد لـ CurrencyValue
    /// </summary>
    public CurrencyValueId Id { get; private set; }

    /// <summary>
    /// AccountCurrency of the CurrencyValue
    /// AccountCurrency الخاص بـ CurrencyValue
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CurValue of the CurrencyValue
    /// CurValue الخاص بـ CurrencyValue
    /// </summary>
    public decimal? CurValue { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion
}
}
