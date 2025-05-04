using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerRequest Identifier Value Object
/// </summary>
public sealed class CustomerRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerRequestId instance
    /// </summary>
    public CustomerRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerRequestId with a new GUID
    /// </summary>
    public static CustomerRequestId CreateUnique()
    {
        return new CustomerRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerRequestId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerRequestId id) => id.Value;
}
}
