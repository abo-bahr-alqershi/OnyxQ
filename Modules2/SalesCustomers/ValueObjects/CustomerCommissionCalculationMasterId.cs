using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerCommissionCalculationMaster Identifier Value Object
/// </summary>
public sealed class CustomerCommissionCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerCommissionCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerCommissionCalculationMasterId instance
    /// </summary>
    public CustomerCommissionCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerCommissionCalculationMasterId with a new GUID
    /// </summary>
    public static CustomerCommissionCalculationMasterId CreateUnique()
    {
        return new CustomerCommissionCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerCommissionCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerCommissionCalculationMasterId id) => id.Value;
}
}
