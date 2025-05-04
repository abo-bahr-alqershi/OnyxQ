using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCurrencyUserLimit Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCurrencyUserLimitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCurrencyUserLimit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCurrencyUserLimitId instance
    /// </summary>
    public GeneralLedgerCurrencyUserLimitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCurrencyUserLimitId with a new GUID
    /// </summary>
    public static GeneralLedgerCurrencyUserLimitId CreateUnique()
    {
        return new GeneralLedgerCurrencyUserLimitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCurrencyUserLimitId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCurrencyUserLimitId id) => id.Value;
}
}
