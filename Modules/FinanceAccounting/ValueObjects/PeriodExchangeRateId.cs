using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// PeriodExchangeRate Identifier Value Object
/// </summary>
public sealed class PeriodExchangeRateId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PeriodExchangeRate
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PeriodExchangeRateId instance
    /// </summary>
    public PeriodExchangeRateId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PeriodExchangeRateId with a new GUID
    /// </summary>
    public static PeriodExchangeRateId CreateUnique()
    {
        return new PeriodExchangeRateId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PeriodExchangeRateId id) => id.Value.ToString();
    public static implicit operator Guid(PeriodExchangeRateId id) => id.Value;
}
}
