using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCostCenterLimit Identifier Value Object
/// </summary>
public sealed class CustomerCostCenterLimitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCostCenterLimit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCostCenterLimitId instance
    /// </summary>
    public CustomerCostCenterLimitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCostCenterLimitId with a new GUID
    /// </summary>
    public static CustomerCostCenterLimitId CreateUnique()
    {
        return new CustomerCostCenterLimitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCostCenterLimitId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCostCenterLimitId id) => id.Value;
}
}
