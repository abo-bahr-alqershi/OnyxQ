using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchBillDetail Identifier Value Object
/// </summary>
public sealed class BranchBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchBillDetailId instance
    /// </summary>
    public BranchBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchBillDetailId with a new GUID
    /// </summary>
    public static BranchBillDetailId CreateUnique()
    {
        return new BranchBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchBillDetailId id) => id.Value;
}
}
