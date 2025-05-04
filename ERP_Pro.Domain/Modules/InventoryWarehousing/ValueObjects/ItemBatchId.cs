using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemBatch Identifier Value Object
/// </summary>
public sealed class ItemBatchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemBatch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemBatchId instance
    /// </summary>
    public ItemBatchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemBatchId with a new GUID
    /// </summary>
    public static ItemBatchId CreateUnique()
    {
        return new ItemBatchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemBatchId id) => id.Value.ToString();
    public static implicit operator Guid(ItemBatchId id) => id.Value;
}
}
