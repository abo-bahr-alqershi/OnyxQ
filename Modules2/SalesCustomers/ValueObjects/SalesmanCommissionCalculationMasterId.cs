using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanCommissionCalculationMaster Identifier Value Object
/// </summary>
public sealed class SalesmanCommissionCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanCommissionCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanCommissionCalculationMasterId instance
    /// </summary>
    public SalesmanCommissionCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanCommissionCalculationMasterId with a new GUID
    /// </summary>
    public static SalesmanCommissionCalculationMasterId CreateUnique()
    {
        return new SalesmanCommissionCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanCommissionCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanCommissionCalculationMasterId id) => id.Value;
}
}
