using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PromotionCustomer Identifier Value Object
/// </summary>
public sealed class PromotionCustomerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PromotionCustomer
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromotionCustomerId instance
    /// </summary>
    public PromotionCustomerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromotionCustomerId with a new GUID
    /// </summary>
    public static PromotionCustomerId CreateUnique()
    {
        return new PromotionCustomerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromotionCustomerId id) => id.Value.ToString();
    public static implicit operator Guid(PromotionCustomerId id) => id.Value;
}
}
