using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CurrencyValue Identifier Value Object
/// </summary>
public sealed class CurrencyValueId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CurrencyValue
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CurrencyValueId instance
    /// </summary>
    public CurrencyValueId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CurrencyValueId with a new GUID
    /// </summary>
    public static CurrencyValueId CreateUnique()
    {
        return new CurrencyValueId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CurrencyValueId id) => id.Value.ToString();
    public static implicit operator Guid(CurrencyValueId id) => id.Value;
}
}
