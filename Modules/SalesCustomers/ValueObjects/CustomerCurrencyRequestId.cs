using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCurrencyRequest Identifier Value Object
/// </summary>
public sealed class CustomerCurrencyRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCurrencyRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCurrencyRequestId instance
    /// </summary>
    public CustomerCurrencyRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCurrencyRequestId with a new GUID
    /// </summary>
    public static CustomerCurrencyRequestId CreateUnique()
    {
        return new CustomerCurrencyRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCurrencyRequestId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCurrencyRequestId id) => id.Value;
}
}
