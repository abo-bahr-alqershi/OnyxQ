using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// QuotationPromotionSubDetail Identifier Value Object
/// </summary>
public sealed class QuotationPromotionSubDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuotationPromotionSubDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationPromotionSubDetailId instance
    /// </summary>
    public QuotationPromotionSubDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationPromotionSubDetailId with a new GUID
    /// </summary>
    public static QuotationPromotionSubDetailId CreateUnique()
    {
        return new QuotationPromotionSubDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationPromotionSubDetailId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationPromotionSubDetailId id) => id.Value;
}
}
