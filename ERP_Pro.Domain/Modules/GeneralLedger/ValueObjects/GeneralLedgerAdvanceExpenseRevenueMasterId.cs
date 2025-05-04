using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAdvanceExpenseRevenueMaster Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAdvanceExpenseRevenueMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAdvanceExpenseRevenueMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAdvanceExpenseRevenueMasterId instance
    /// </summary>
    public GeneralLedgerAdvanceExpenseRevenueMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAdvanceExpenseRevenueMasterId with a new GUID
    /// </summary>
    public static GeneralLedgerAdvanceExpenseRevenueMasterId CreateUnique()
    {
        return new GeneralLedgerAdvanceExpenseRevenueMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAdvanceExpenseRevenueMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAdvanceExpenseRevenueMasterId id) => id.Value;
}
}
