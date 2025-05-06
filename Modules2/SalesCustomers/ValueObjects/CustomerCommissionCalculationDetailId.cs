using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCommissionCalculationDetail Identifier Value Object
/// </summary>
public sealed class CustomerCommissionCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCommissionCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCommissionCalculationDetailId instance
    /// </summary>
    public CustomerCommissionCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCommissionCalculationDetailId with a new GUID
    /// </summary>
    public static CustomerCommissionCalculationDetailId CreateUnique()
    {
        return new CustomerCommissionCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCommissionCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCommissionCalculationDetailId id) => id.Value;
}
}
