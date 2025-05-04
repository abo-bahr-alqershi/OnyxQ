using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerClassType Identifier Value Object
/// </summary>
public sealed class CustomerClassTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerClassType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerClassTypeId instance
    /// </summary>
    public CustomerClassTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerClassTypeId with a new GUID
    /// </summary>
    public static CustomerClassTypeId CreateUnique()
    {
        return new CustomerClassTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerClassTypeId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerClassTypeId id) => id.Value;
}
}
