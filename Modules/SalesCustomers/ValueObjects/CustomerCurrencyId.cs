using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCurrency Identifier Value Object
/// </summary>
public sealed class CustomerCurrencyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCurrency
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCurrencyId instance
    /// </summary>
    public CustomerCurrencyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCurrencyId with a new GUID
    /// </summary>
    public static CustomerCurrencyId CreateUnique()
    {
        return new CustomerCurrencyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCurrencyId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCurrencyId id) => id.Value;
}
}
