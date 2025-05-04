using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerMoveBudgetDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerMoveBudgetDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerMoveBudgetDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerMoveBudgetDetailId instance
    /// </summary>
    public GeneralLedgerMoveBudgetDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerMoveBudgetDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerMoveBudgetDetailId CreateUnique()
    {
        return new GeneralLedgerMoveBudgetDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerMoveBudgetDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerMoveBudgetDetailId id) => id.Value;
}
}
