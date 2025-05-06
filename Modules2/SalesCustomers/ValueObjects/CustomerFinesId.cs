using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerFines Identifier Value Object
/// </summary>
public sealed class CustomerFinesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerFines
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerFinesId instance
    /// </summary>
    public CustomerFinesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerFinesId with a new GUID
    /// </summary>
    public static CustomerFinesId CreateUnique()
    {
        return new CustomerFinesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerFinesId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerFinesId id) => id.Value;
}
}
