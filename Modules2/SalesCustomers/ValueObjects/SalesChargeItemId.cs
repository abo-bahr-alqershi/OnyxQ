using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesChargeItem Identifier Value Object
/// </summary>
public sealed class SalesChargeItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesChargeItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesChargeItemId instance
    /// </summary>
    public SalesChargeItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesChargeItemId with a new GUID
    /// </summary>
    public static SalesChargeItemId CreateUnique()
    {
        return new SalesChargeItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesChargeItemId id) => id.Value.ToString();
    public static implicit operator Guid(SalesChargeItemId id) => id.Value;
}
}
