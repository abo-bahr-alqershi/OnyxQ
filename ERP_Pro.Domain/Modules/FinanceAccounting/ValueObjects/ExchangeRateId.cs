using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// ExchangeRate Identifier Value Object
/// </summary>
public sealed class ExchangeRateId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExchangeRate
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExchangeRateId instance
    /// </summary>
    public ExchangeRateId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExchangeRateId with a new GUID
    /// </summary>
    public static ExchangeRateId CreateUnique()
    {
        return new ExchangeRateId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExchangeRateId id) => id.Value.ToString();
    public static implicit operator Guid(ExchangeRateId id) => id.Value;
}
}
