using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCollector Identifier Value Object
/// </summary>
public sealed class CustomerCollectorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCollector
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCollectorId instance
    /// </summary>
    public CustomerCollectorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCollectorId with a new GUID
    /// </summary>
    public static CustomerCollectorId CreateUnique()
    {
        return new CustomerCollectorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCollectorId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCollectorId id) => id.Value;
}
}
