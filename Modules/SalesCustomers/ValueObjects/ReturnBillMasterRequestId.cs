using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// ReturnBillMasterRequest Identifier Value Object
/// </summary>
public sealed class ReturnBillMasterRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReturnBillMasterRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReturnBillMasterRequestId instance
    /// </summary>
    public ReturnBillMasterRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReturnBillMasterRequestId with a new GUID
    /// </summary>
    public static ReturnBillMasterRequestId CreateUnique()
    {
        return new ReturnBillMasterRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReturnBillMasterRequestId id) => id.Value.ToString();
    public static implicit operator Guid(ReturnBillMasterRequestId id) => id.Value;
}
}
