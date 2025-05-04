using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCashflowAccount Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCashflowAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowAccountId instance
    /// </summary>
    public GeneralLedgerCashflowAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowAccountId with a new GUID
    /// </summary>
    public static GeneralLedgerCashflowAccountId CreateUnique()
    {
        return new GeneralLedgerCashflowAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCashflowAccountId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCashflowAccountId id) => id.Value;
}
}
