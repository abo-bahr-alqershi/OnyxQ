using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionCommissionSetupDetail Identifier Value Object
/// </summary>
public sealed class PromotionCommissionSetupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionCommissionSetupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionCommissionSetupDetailId instance
    /// </summary>
    public PromotionCommissionSetupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionCommissionSetupDetailId with a new GUID
    /// </summary>
    public static PromotionCommissionSetupDetailId CreateUnique()
    {
        return new PromotionCommissionSetupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionCommissionSetupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionCommissionSetupDetailId id) => id.Value;
}
}
