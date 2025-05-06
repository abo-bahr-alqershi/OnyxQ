using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// QuotationPromotionMaster Identifier Value Object
/// </summary>
public sealed class QuotationPromotionMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuotationPromotionMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationPromotionMasterId instance
    /// </summary>
    public QuotationPromotionMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationPromotionMasterId with a new GUID
    /// </summary>
    public static QuotationPromotionMasterId CreateUnique()
    {
        return new QuotationPromotionMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationPromotionMasterId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationPromotionMasterId id) => id.Value;
}
}
