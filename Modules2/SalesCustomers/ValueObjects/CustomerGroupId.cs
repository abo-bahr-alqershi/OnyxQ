using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerGroup Identifier Value Object
/// </summary>
public sealed class CustomerGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerGroupId instance
    /// </summary>
    public CustomerGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerGroupId with a new GUID
    /// </summary>
    public static CustomerGroupId CreateUnique()
    {
        return new CustomerGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerGroupId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerGroupId id) => id.Value;
}
}
