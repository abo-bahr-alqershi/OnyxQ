using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CurrencyValue Entity
/// </summary>
public class CurrencyValue : Entity<CurrencyValueId>
{

    private CurrencyValue() { }

    public CurrencyValue(CurrencyValueId id, decimal? curValue)
    {
        Id = id;
        CurValue = curValue;
    }

    /// <summary>
    /// The unique identifier for the CurrencyValue
    /// المعرف الفريد لـ CurrencyValue
    /// </summary>
    public CurrencyValueId Id { get; private set; }

    /// <summary>
    /// CurValue of the CurrencyValue
    /// CurValue الخاص بـ CurrencyValue
    /// </summary>
    public decimal? CurValue { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

