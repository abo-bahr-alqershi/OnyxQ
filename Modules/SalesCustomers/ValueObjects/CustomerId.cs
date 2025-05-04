using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// Customer Identifier Value Object
/// </summary>
public sealed class CustomerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Customer
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerId instance
    /// </summary>
    public CustomerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerId with a new GUID
    /// </summary>
    public static CustomerId CreateUnique()
    {
        return new CustomerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerId id) => id.Value;
}
}
