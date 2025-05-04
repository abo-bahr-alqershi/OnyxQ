using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BranchJournalVoucherMaster Identifier Value Object
/// </summary>
public sealed class BranchJournalVoucherMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchJournalVoucherMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchJournalVoucherMasterId instance
    /// </summary>
    public BranchJournalVoucherMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchJournalVoucherMasterId with a new GUID
    /// </summary>
    public static BranchJournalVoucherMasterId CreateUnique()
    {
        return new BranchJournalVoucherMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchJournalVoucherMasterId id) => id.Value.ToString();
    public static implicit operator Guid(BranchJournalVoucherMasterId id) => id.Value;
}
}
