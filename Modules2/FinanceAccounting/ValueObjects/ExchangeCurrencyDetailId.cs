using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// ExchangeCurrencyDetail Identifier Value Object
/// </summary>
public sealed class ExchangeCurrencyDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExchangeCurrencyDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExchangeCurrencyDetailId instance
    /// </summary>
    public ExchangeCurrencyDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExchangeCurrencyDetailId with a new GUID
    /// </summary>
    public static ExchangeCurrencyDetailId CreateUnique()
    {
        return new ExchangeCurrencyDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExchangeCurrencyDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ExchangeCurrencyDetailId id) => id.Value;
}
}
