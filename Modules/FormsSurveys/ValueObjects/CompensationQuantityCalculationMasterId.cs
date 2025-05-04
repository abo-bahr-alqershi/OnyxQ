using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// CompensationQuantityCalculationMaster Identifier Value Object
/// </summary>
public sealed class CompensationQuantityCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompensationQuantityCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompensationQuantityCalculationMasterId instance
    /// </summary>
    public CompensationQuantityCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompensationQuantityCalculationMasterId with a new GUID
    /// </summary>
    public static CompensationQuantityCalculationMasterId CreateUnique()
    {
        return new CompensationQuantityCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompensationQuantityCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CompensationQuantityCalculationMasterId id) => id.Value;
}
}
