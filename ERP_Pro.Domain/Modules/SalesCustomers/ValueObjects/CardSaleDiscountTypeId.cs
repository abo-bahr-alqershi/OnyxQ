using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CardSaleDiscountType Identifier Value Object
/// </summary>
public sealed class CardSaleDiscountTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CardSaleDiscountType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CardSaleDiscountTypeId instance
    /// </summary>
    public CardSaleDiscountTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CardSaleDiscountTypeId with a new GUID
    /// </summary>
    public static CardSaleDiscountTypeId CreateUnique()
    {
        return new CardSaleDiscountTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CardSaleDiscountTypeId id) => id.Value.ToString();
    public static implicit operator Guid(CardSaleDiscountTypeId id) => id.Value;
}
}
