using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerClass Identifier Value Object
/// </summary>
public sealed class CustomerClassId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerClass
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerClassId instance
    /// </summary>
    public CustomerClassId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerClassId with a new GUID
    /// </summary>
    public static CustomerClassId CreateUnique()
    {
        return new CustomerClassId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerClassId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerClassId id) => id.Value;
}
}
