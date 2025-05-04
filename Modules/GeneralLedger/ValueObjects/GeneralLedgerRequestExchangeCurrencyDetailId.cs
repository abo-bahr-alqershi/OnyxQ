using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerRequestExchangeCurrencyDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerRequestExchangeCurrencyDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerRequestExchangeCurrencyDetailId instance
    /// </summary>
    public GeneralLedgerRequestExchangeCurrencyDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerRequestExchangeCurrencyDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerRequestExchangeCurrencyDetailId CreateUnique()
    {
        return new GeneralLedgerRequestExchangeCurrencyDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerRequestExchangeCurrencyDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerRequestExchangeCurrencyDetailId id) => id.Value;
}
}
