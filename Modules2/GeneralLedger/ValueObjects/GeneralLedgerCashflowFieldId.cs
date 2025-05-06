using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCashflowField Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCashflowFieldId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowField
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowFieldId instance
    /// </summary>
    public GeneralLedgerCashflowFieldId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowFieldId with a new GUID
    /// </summary>
    public static GeneralLedgerCashflowFieldId CreateUnique()
    {
        return new GeneralLedgerCashflowFieldId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCashflowFieldId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCashflowFieldId id) => id.Value;
}
}
