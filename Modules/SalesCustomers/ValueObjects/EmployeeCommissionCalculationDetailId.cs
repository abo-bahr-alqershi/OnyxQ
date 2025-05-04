using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// EmployeeCommissionCalculationDetail Identifier Value Object
/// </summary>
public sealed class EmployeeCommissionCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeCommissionCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeCommissionCalculationDetailId instance
    /// </summary>
    public EmployeeCommissionCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeCommissionCalculationDetailId with a new GUID
    /// </summary>
    public static EmployeeCommissionCalculationDetailId CreateUnique()
    {
        return new EmployeeCommissionCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeCommissionCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeCommissionCalculationDetailId id) => id.Value;
}
}
