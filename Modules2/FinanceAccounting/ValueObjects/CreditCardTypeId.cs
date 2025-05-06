using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CreditCardType Identifier Value Object
/// </summary>
public sealed class CreditCardTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CreditCardType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CreditCardTypeId instance
    /// </summary>
    public CreditCardTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CreditCardTypeId with a new GUID
    /// </summary>
    public static CreditCardTypeId CreateUnique()
    {
        return new CreditCardTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CreditCardTypeId id) => id.Value.ToString();
    public static implicit operator Guid(CreditCardTypeId id) => id.Value;
}
}
