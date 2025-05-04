using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionItem Identifier Value Object
/// </summary>
public sealed class PromotionItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionItemId instance
    /// </summary>
    public PromotionItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionItemId with a new GUID
    /// </summary>
    public static PromotionItemId CreateUnique()
    {
        return new PromotionItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionItemId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionItemId id) => id.Value;
}
}
