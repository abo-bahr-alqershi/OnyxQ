using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCostCenterLimitRequest Identifier Value Object
/// </summary>
public sealed class CustomerCostCenterLimitRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCostCenterLimitRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCostCenterLimitRequestId instance
    /// </summary>
    public CustomerCostCenterLimitRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCostCenterLimitRequestId with a new GUID
    /// </summary>
    public static CustomerCostCenterLimitRequestId CreateUnique()
    {
        return new CustomerCostCenterLimitRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCostCenterLimitRequestId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCostCenterLimitRequestId id) => id.Value;
}
}
