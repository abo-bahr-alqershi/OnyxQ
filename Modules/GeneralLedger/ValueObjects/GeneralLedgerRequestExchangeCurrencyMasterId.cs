using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerRequestExchangeCurrencyMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerRequestExchangeCurrencyMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerRequestExchangeCurrencyMasterId instance
    /// </summary>
    public GeneralLedgerRequestExchangeCurrencyMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerRequestExchangeCurrencyMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerRequestExchangeCurrencyMasterId CreateUnique()
    {
        return new GeneralLedgerRequestExchangeCurrencyMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerRequestExchangeCurrencyMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerRequestExchangeCurrencyMasterId id) => id.Value;
}
}
