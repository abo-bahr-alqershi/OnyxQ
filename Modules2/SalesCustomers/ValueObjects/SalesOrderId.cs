using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesOrder Identifier Value Object
/// </summary>
public sealed class SalesOrderId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesOrder
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesOrderId instance
    /// </summary>
    public SalesOrderId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesOrderId with a new GUID
    /// </summary>
    public static SalesOrderId CreateUnique()
    {
        return new SalesOrderId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesOrderId id) => id.Value.ToString();
    public static implicit operator Guid(SalesOrderId id) => id.Value;
}
}
