using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CollectorCommissionCalculationMaster Identifier Value Object
/// </summary>
public sealed class CollectorCommissionCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CollectorCommissionCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorCommissionCalculationMasterId instance
    /// </summary>
    public CollectorCommissionCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorCommissionCalculationMasterId with a new GUID
    /// </summary>
    public static CollectorCommissionCalculationMasterId CreateUnique()
    {
        return new CollectorCommissionCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorCommissionCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorCommissionCalculationMasterId id) => id.Value;
}
}
