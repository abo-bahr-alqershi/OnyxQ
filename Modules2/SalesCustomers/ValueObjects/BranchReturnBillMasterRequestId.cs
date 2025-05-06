using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// BranchReturnBillMasterRequest Identifier Value Object
/// </summary>
public sealed class BranchReturnBillMasterRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchReturnBillMasterRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchReturnBillMasterRequestId instance
    /// </summary>
    public BranchReturnBillMasterRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchReturnBillMasterRequestId with a new GUID
    /// </summary>
    public static BranchReturnBillMasterRequestId CreateUnique()
    {
        return new BranchReturnBillMasterRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchReturnBillMasterRequestId id) => id.Value.ToString();
    public static implicit operator Guid(BranchReturnBillMasterRequestId id) => id.Value;
}
}
