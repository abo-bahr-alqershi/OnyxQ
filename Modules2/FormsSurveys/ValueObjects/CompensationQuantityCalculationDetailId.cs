using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// CompensationQuantityCalculationDetail Identifier Value Object
/// </summary>
public sealed class CompensationQuantityCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CompensationQuantityCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CompensationQuantityCalculationDetailId instance
    /// </summary>
    public CompensationQuantityCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CompensationQuantityCalculationDetailId with a new GUID
    /// </summary>
    public static CompensationQuantityCalculationDetailId CreateUnique()
    {
        return new CompensationQuantityCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CompensationQuantityCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CompensationQuantityCalculationDetailId id) => id.Value;
}
}
