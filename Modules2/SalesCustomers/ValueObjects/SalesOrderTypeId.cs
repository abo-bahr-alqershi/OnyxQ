using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesOrderType Identifier Value Object
/// </summary>
public sealed class SalesOrderTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesOrderType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesOrderTypeId instance
    /// </summary>
    public SalesOrderTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesOrderTypeId with a new GUID
    /// </summary>
    public static SalesOrderTypeId CreateUnique()
    {
        return new SalesOrderTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesOrderTypeId id) => id.Value.ToString();
    public static implicit operator Guid(SalesOrderTypeId id) => id.Value;
}
}
