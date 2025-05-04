using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// ExchangeCurrencyMaster Identifier Value Object
/// </summary>
public sealed class ExchangeCurrencyMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ExchangeCurrencyMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ExchangeCurrencyMasterId instance
    /// </summary>
    public ExchangeCurrencyMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ExchangeCurrencyMasterId with a new GUID
    /// </summary>
    public static ExchangeCurrencyMasterId CreateUnique()
    {
        return new ExchangeCurrencyMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ExchangeCurrencyMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ExchangeCurrencyMasterId id) => id.Value;
}
}
