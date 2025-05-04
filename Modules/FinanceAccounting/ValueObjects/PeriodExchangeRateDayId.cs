using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// PeriodExchangeRateDay Identifier Value Object
/// </summary>
public sealed class PeriodExchangeRateDayId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodExchangeRateDay
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodExchangeRateDayId instance
    /// </summary>
    public PeriodExchangeRateDayId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodExchangeRateDayId with a new GUID
    /// </summary>
    public static PeriodExchangeRateDayId CreateUnique()
    {
        return new PeriodExchangeRateDayId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodExchangeRateDayId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodExchangeRateDayId id) => id.Value;
}
}
