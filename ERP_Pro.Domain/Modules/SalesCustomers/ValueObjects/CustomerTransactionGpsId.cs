using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerTransactionGps Identifier Value Object
/// </summary>
public sealed class CustomerTransactionGpsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerTransactionGps
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerTransactionGpsId instance
    /// </summary>
    public CustomerTransactionGpsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerTransactionGpsId with a new GUID
    /// </summary>
    public static CustomerTransactionGpsId CreateUnique()
    {
        return new CustomerTransactionGpsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerTransactionGpsId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerTransactionGpsId id) => id.Value;
}
}
