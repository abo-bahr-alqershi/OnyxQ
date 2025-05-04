using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerItemLimitSale Identifier Value Object
/// </summary>
public sealed class CustomerItemLimitSaleId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerItemLimitSale
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerItemLimitSaleId instance
    /// </summary>
    public CustomerItemLimitSaleId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerItemLimitSaleId with a new GUID
    /// </summary>
    public static CustomerItemLimitSaleId CreateUnique()
    {
        return new CustomerItemLimitSaleId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerItemLimitSaleId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerItemLimitSaleId id) => id.Value;
}
}
