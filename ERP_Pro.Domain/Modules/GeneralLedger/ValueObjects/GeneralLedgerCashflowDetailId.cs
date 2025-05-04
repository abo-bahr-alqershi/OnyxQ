using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCashflowDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCashflowDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowDetailId instance
    /// </summary>
    public GeneralLedgerCashflowDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerCashflowDetailId CreateUnique()
    {
        return new GeneralLedgerCashflowDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCashflowDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCashflowDetailId id) => id.Value;
}
}
