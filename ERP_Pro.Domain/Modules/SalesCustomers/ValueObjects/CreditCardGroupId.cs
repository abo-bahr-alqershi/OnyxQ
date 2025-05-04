using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CreditCardGroup Identifier Value Object
/// </summary>
public sealed class CreditCardGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CreditCardGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CreditCardGroupId instance
    /// </summary>
    public CreditCardGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CreditCardGroupId with a new GUID
    /// </summary>
    public static CreditCardGroupId CreateUnique()
    {
        return new CreditCardGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CreditCardGroupId id) => id.Value.ToString();
    public static implicit operator Guid(CreditCardGroupId id) => id.Value;
}
}
