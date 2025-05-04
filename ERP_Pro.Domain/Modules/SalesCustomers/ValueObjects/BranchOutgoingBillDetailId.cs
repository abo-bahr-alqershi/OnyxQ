using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchOutgoingBillDetail Identifier Value Object
/// </summary>
public sealed class BranchOutgoingBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchOutgoingBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchOutgoingBillDetailId instance
    /// </summary>
    public BranchOutgoingBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchOutgoingBillDetailId with a new GUID
    /// </summary>
    public static BranchOutgoingBillDetailId CreateUnique()
    {
        return new BranchOutgoingBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchOutgoingBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchOutgoingBillDetailId id) => id.Value;
}
}
