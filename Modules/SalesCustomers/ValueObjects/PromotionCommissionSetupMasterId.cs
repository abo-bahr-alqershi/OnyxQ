using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionCommissionSetupMaster Identifier Value Object
/// </summary>
public sealed class PromotionCommissionSetupMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionCommissionSetupMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionCommissionSetupMasterId instance
    /// </summary>
    public PromotionCommissionSetupMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionCommissionSetupMasterId with a new GUID
    /// </summary>
    public static PromotionCommissionSetupMasterId CreateUnique()
    {
        return new PromotionCommissionSetupMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionCommissionSetupMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionCommissionSetupMasterId id) => id.Value;
}
}
