using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionCommissionCalculationMaster Identifier Value Object
/// </summary>
public sealed class PromotionCommissionCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionCommissionCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionCommissionCalculationMasterId instance
    /// </summary>
    public PromotionCommissionCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionCommissionCalculationMasterId with a new GUID
    /// </summary>
    public static PromotionCommissionCalculationMasterId CreateUnique()
    {
        return new PromotionCommissionCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionCommissionCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionCommissionCalculationMasterId id) => id.Value;
}
}
