using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// QuotationPromotionDetail Identifier Value Object
/// </summary>
public sealed class QuotationPromotionDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuotationPromotionDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationPromotionDetailId instance
    /// </summary>
    public QuotationPromotionDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationPromotionDetailId with a new GUID
    /// </summary>
    public static QuotationPromotionDetailId CreateUnique()
    {
        return new QuotationPromotionDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationPromotionDetailId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationPromotionDetailId id) => id.Value;
}
}
