using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerSigns Identifier Value Object
/// </summary>
public sealed class CustomerSignsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerSigns
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerSignsId instance
    /// </summary>
    public CustomerSignsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerSignsId with a new GUID
    /// </summary>
    public static CustomerSignsId CreateUnique()
    {
        return new CustomerSignsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerSignsId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerSignsId id) => id.Value;
}
}
