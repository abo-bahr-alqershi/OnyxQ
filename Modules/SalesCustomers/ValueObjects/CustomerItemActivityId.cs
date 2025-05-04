using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerItemActivity Identifier Value Object
/// </summary>
public sealed class CustomerItemActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerItemActivity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerItemActivityId instance
    /// </summary>
    public CustomerItemActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerItemActivityId with a new GUID
    /// </summary>
    public static CustomerItemActivityId CreateUnique()
    {
        return new CustomerItemActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerItemActivityId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerItemActivityId id) => id.Value;
}
}
