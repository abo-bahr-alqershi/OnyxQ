using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerLocation Identifier Value Object
/// </summary>
public sealed class CustomerLocationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerLocation
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerLocationId instance
    /// </summary>
    public CustomerLocationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerLocationId with a new GUID
    /// </summary>
    public static CustomerLocationId CreateUnique()
    {
        return new CustomerLocationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerLocationId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerLocationId id) => id.Value;
}
}
