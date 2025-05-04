using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryBatchNumberMethodDetail Identifier Value Object
/// </summary>
public sealed class InventoryBatchNumberMethodDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryBatchNumberMethodDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryBatchNumberMethodDetailId instance
    /// </summary>
    public InventoryBatchNumberMethodDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryBatchNumberMethodDetailId with a new GUID
    /// </summary>
    public static InventoryBatchNumberMethodDetailId CreateUnique()
    {
        return new InventoryBatchNumberMethodDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryBatchNumberMethodDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryBatchNumberMethodDetailId id) => id.Value;
}
}
