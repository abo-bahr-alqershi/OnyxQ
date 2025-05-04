using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerSalesman Identifier Value Object
/// </summary>
public sealed class CustomerSalesmanId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerSalesman
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerSalesmanId instance
    /// </summary>
    public CustomerSalesmanId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerSalesmanId with a new GUID
    /// </summary>
    public static CustomerSalesmanId CreateUnique()
    {
        return new CustomerSalesmanId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerSalesmanId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerSalesmanId id) => id.Value;
}
}
