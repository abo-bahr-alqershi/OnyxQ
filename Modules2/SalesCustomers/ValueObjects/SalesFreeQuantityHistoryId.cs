using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesFreeQuantityHistory Identifier Value Object
/// </summary>
public sealed class SalesFreeQuantityHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesFreeQuantityHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesFreeQuantityHistoryId instance
    /// </summary>
    public SalesFreeQuantityHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesFreeQuantityHistoryId with a new GUID
    /// </summary>
    public static SalesFreeQuantityHistoryId CreateUnique()
    {
        return new SalesFreeQuantityHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesFreeQuantityHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(SalesFreeQuantityHistoryId id) => id.Value;
}
}
