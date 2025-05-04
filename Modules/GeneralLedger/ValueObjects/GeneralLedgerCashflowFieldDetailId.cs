using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerCashflowFieldDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerCashflowFieldDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerCashflowFieldDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowFieldDetailId instance
    /// </summary>
    public GeneralLedgerCashflowFieldDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerCashflowFieldDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerCashflowFieldDetailId CreateUnique()
    {
        return new GeneralLedgerCashflowFieldDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerCashflowFieldDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerCashflowFieldDetailId id) => id.Value;
}
}
