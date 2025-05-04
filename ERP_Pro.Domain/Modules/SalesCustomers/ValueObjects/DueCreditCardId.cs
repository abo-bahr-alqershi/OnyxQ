using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// DueCreditCard Identifier Value Object
/// </summary>
public sealed class DueCreditCardId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DueCreditCard
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DueCreditCardId instance
    /// </summary>
    public DueCreditCardId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DueCreditCardId with a new GUID
    /// </summary>
    public static DueCreditCardId CreateUnique()
    {
        return new DueCreditCardId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DueCreditCardId id) => id.Value.ToString();
    public static implicit operator Guid(DueCreditCardId id) => id.Value;
}
}
