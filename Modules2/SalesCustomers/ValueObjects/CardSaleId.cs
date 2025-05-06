using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CardSale Identifier Value Object
/// </summary>
public sealed class CardSaleId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CardSale
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CardSaleId instance
    /// </summary>
    public CardSaleId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CardSaleId with a new GUID
    /// </summary>
    public static CardSaleId CreateUnique()
    {
        return new CardSaleId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CardSaleId id) => id.Value.ToString();
    public static implicit operator Guid(CardSaleId id) => id.Value;
}
}
