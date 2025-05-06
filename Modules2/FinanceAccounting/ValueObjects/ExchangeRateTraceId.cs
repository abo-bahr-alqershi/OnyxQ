using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// ExchangeRateTrace Identifier Value Object
/// </summary>
public sealed class ExchangeRateTraceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExchangeRateTrace
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExchangeRateTraceId instance
    /// </summary>
    public ExchangeRateTraceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExchangeRateTraceId with a new GUID
    /// </summary>
    public static ExchangeRateTraceId CreateUnique()
    {
        return new ExchangeRateTraceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExchangeRateTraceId id) => id.Value.ToString();
    public static implicit operator Guid(ExchangeRateTraceId id) => id.Value;
}
}
