using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// GeneralLedgerAdvanceExpenseRevenueDetail Identifier Value Object
/// </summary>
public sealed class GeneralLedgerAdvanceExpenseRevenueDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralLedgerAdvanceExpenseRevenueDetailId instance
    /// </summary>
    public GeneralLedgerAdvanceExpenseRevenueDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralLedgerAdvanceExpenseRevenueDetailId with a new GUID
    /// </summary>
    public static GeneralLedgerAdvanceExpenseRevenueDetailId CreateUnique()
    {
        return new GeneralLedgerAdvanceExpenseRevenueDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralLedgerAdvanceExpenseRevenueDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralLedgerAdvanceExpenseRevenueDetailId id) => id.Value;
}
}
