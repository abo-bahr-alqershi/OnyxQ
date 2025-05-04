using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// RequestItemCustomer Identifier Value Object
/// </summary>
public sealed class RequestItemCustomerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RequestItemCustomer
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RequestItemCustomerId instance
    /// </summary>
    public RequestItemCustomerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RequestItemCustomerId with a new GUID
    /// </summary>
    public static RequestItemCustomerId CreateUnique()
    {
        return new RequestItemCustomerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RequestItemCustomerId id) => id.Value.ToString();
    public static implicit operator Guid(RequestItemCustomerId id) => id.Value;
}
}
