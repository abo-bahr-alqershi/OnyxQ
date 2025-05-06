using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchReturnBillDetailRequest Identifier Value Object
/// </summary>
public sealed class BranchReturnBillDetailRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchReturnBillDetailRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchReturnBillDetailRequestId instance
    /// </summary>
    public BranchReturnBillDetailRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchReturnBillDetailRequestId with a new GUID
    /// </summary>
    public static BranchReturnBillDetailRequestId CreateUnique()
    {
        return new BranchReturnBillDetailRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchReturnBillDetailRequestId id) => id.Value.ToString();
    public static implicit operator Guid(BranchReturnBillDetailRequestId id) => id.Value;
}
}
