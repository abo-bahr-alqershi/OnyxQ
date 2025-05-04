using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BranchJournalVoucherDetail Identifier Value Object
/// </summary>
public sealed class BranchJournalVoucherDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchJournalVoucherDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchJournalVoucherDetailId instance
    /// </summary>
    public BranchJournalVoucherDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchJournalVoucherDetailId with a new GUID
    /// </summary>
    public static BranchJournalVoucherDetailId CreateUnique()
    {
        return new BranchJournalVoucherDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchJournalVoucherDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchJournalVoucherDetailId id) => id.Value;
}
}
