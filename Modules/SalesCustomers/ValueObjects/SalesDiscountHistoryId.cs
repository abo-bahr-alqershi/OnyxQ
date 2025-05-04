using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesDiscountHistory Identifier Value Object
/// </summary>
public sealed class SalesDiscountHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesDiscountHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesDiscountHistoryId instance
    /// </summary>
    public SalesDiscountHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesDiscountHistoryId with a new GUID
    /// </summary>
    public static SalesDiscountHistoryId CreateUnique()
    {
        return new SalesDiscountHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesDiscountHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(SalesDiscountHistoryId id) => id.Value;
}
}
