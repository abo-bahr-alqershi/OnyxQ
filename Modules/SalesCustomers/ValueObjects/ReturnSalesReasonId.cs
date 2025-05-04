using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// ReturnSalesReason Identifier Value Object
/// </summary>
public sealed class ReturnSalesReasonId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReturnSalesReason
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReturnSalesReasonId instance
    /// </summary>
    public ReturnSalesReasonId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReturnSalesReasonId with a new GUID
    /// </summary>
    public static ReturnSalesReasonId CreateUnique()
    {
        return new ReturnSalesReasonId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReturnSalesReasonId id) => id.Value.ToString();
    public static implicit operator Guid(ReturnSalesReasonId id) => id.Value;
}
}
