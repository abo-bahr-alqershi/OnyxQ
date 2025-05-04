using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionCommissionCalculationDetail Identifier Value Object
/// </summary>
public sealed class PromotionCommissionCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionCommissionCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionCommissionCalculationDetailId instance
    /// </summary>
    public PromotionCommissionCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionCommissionCalculationDetailId with a new GUID
    /// </summary>
    public static PromotionCommissionCalculationDetailId CreateUnique()
    {
        return new PromotionCommissionCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionCommissionCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionCommissionCalculationDetailId id) => id.Value;
}
}
