using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerTaxAccount Identifier Value Object
/// </summary>
public sealed class GeneralLedgerTaxAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerTaxAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerTaxAccountId instance
    /// </summary>
    public GeneralLedgerTaxAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerTaxAccountId with a new GUID
    /// </summary>
    public static GeneralLedgerTaxAccountId CreateUnique()
    {
        return new GeneralLedgerTaxAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerTaxAccountId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerTaxAccountId id) => id.Value;
}
}
