using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// EmployeeCommissionCalculationMaster Identifier Value Object
/// </summary>
public sealed class EmployeeCommissionCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeCommissionCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeCommissionCalculationMasterId instance
    /// </summary>
    public EmployeeCommissionCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeCommissionCalculationMasterId with a new GUID
    /// </summary>
    public static EmployeeCommissionCalculationMasterId CreateUnique()
    {
        return new EmployeeCommissionCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeCommissionCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeCommissionCalculationMasterId id) => id.Value;
}
}
