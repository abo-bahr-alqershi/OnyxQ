using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAccountDetailCurrency Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAccountDetailCurrencyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAccountDetailCurrency
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailCurrencyId instance
    /// </summary>
    public GeneralLedgerAccountDetailCurrencyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAccountDetailCurrencyId with a new GUID
    /// </summary>
    public static GeneralLedgerAccountDetailCurrencyId CreateUnique()
    {
        return new GeneralLedgerAccountDetailCurrencyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAccountDetailCurrencyId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAccountDetailCurrencyId id) => id.Value;
}
}
