using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerLimitSale Identifier Value Object
/// </summary>
public sealed class CustomerLimitSaleId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerLimitSale
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerLimitSaleId instance
    /// </summary>
    public CustomerLimitSaleId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerLimitSaleId with a new GUID
    /// </summary>
    public static CustomerLimitSaleId CreateUnique()
    {
        return new CustomerLimitSaleId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerLimitSaleId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerLimitSaleId id) => id.Value;
}
}
