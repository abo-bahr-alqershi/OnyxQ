using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerContactUs Identifier Value Object
/// </summary>
public sealed class CustomerContactUsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerContactUs
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerContactUsId instance
    /// </summary>
    public CustomerContactUsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerContactUsId with a new GUID
    /// </summary>
    public static CustomerContactUsId CreateUnique()
    {
        return new CustomerContactUsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerContactUsId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerContactUsId id) => id.Value;
}
}
