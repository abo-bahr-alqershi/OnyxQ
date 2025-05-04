using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// OpeningStock Identifier Value Object
/// </summary>
public sealed class OpeningStockId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OpeningStock
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OpeningStockId instance
    /// </summary>
    public OpeningStockId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OpeningStockId with a new GUID
    /// </summary>
    public static OpeningStockId CreateUnique()
    {
        return new OpeningStockId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OpeningStockId id) => id.Value.ToString();
    public static implicit operator Guid(OpeningStockId id) => id.Value;
}
}
