using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// ReturnBillDetailRequest Identifier Value Object
/// </summary>
public sealed class ReturnBillDetailRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReturnBillDetailRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReturnBillDetailRequestId instance
    /// </summary>
    public ReturnBillDetailRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReturnBillDetailRequestId with a new GUID
    /// </summary>
    public static ReturnBillDetailRequestId CreateUnique()
    {
        return new ReturnBillDetailRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReturnBillDetailRequestId id) => id.Value.ToString();
    public static implicit operator Guid(ReturnBillDetailRequestId id) => id.Value;
}
}
