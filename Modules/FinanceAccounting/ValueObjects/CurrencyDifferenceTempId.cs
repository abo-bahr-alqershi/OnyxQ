using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CurrencyDifferenceTemp Identifier Value Object
/// </summary>
public sealed class CurrencyDifferenceTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CurrencyDifferenceTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CurrencyDifferenceTempId instance
    /// </summary>
    public CurrencyDifferenceTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CurrencyDifferenceTempId with a new GUID
    /// </summary>
    public static CurrencyDifferenceTempId CreateUnique()
    {
        return new CurrencyDifferenceTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CurrencyDifferenceTempId id) => id.Value.ToString();
    public static implicit operator Guid(CurrencyDifferenceTempId id) => id.Value;
}
}
