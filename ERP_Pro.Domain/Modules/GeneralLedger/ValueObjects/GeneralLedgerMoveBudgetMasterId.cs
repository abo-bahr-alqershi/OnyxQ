using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerMoveBudgetMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerMoveBudgetMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerMoveBudgetMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerMoveBudgetMasterId instance
    /// </summary>
    public GeneralLedgerMoveBudgetMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerMoveBudgetMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerMoveBudgetMasterId CreateUnique()
    {
        return new GeneralLedgerMoveBudgetMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerMoveBudgetMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerMoveBudgetMasterId id) => id.Value;
}
}
