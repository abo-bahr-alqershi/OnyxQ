using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchReturnBillDetail Identifier Value Object
/// </summary>
public sealed class BranchReturnBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchReturnBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchReturnBillDetailId instance
    /// </summary>
    public BranchReturnBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchReturnBillDetailId with a new GUID
    /// </summary>
    public static BranchReturnBillDetailId CreateUnique()
    {
        return new BranchReturnBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchReturnBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchReturnBillDetailId id) => id.Value;
}
}
