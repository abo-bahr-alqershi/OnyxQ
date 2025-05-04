using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// QuotationPromotionGroupDetail Identifier Value Object
/// </summary>
public sealed class QuotationPromotionGroupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuotationPromotionGroupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationPromotionGroupDetailId instance
    /// </summary>
    public QuotationPromotionGroupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationPromotionGroupDetailId with a new GUID
    /// </summary>
    public static QuotationPromotionGroupDetailId CreateUnique()
    {
        return new QuotationPromotionGroupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationPromotionGroupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationPromotionGroupDetailId id) => id.Value;
}
}
