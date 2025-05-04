using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// ReturnBillDetail Identifier Value Object
/// </summary>
public sealed class ReturnBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReturnBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReturnBillDetailId instance
    /// </summary>
    public ReturnBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReturnBillDetailId with a new GUID
    /// </summary>
    public static ReturnBillDetailId CreateUnique()
    {
        return new ReturnBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReturnBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ReturnBillDetailId id) => id.Value;
}
}
