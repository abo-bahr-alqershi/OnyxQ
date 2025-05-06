using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryItemBinMovement Identifier Value Object
/// </summary>
public sealed class InventoryItemBinMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryItemBinMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryItemBinMovementId instance
    /// </summary>
    public InventoryItemBinMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryItemBinMovementId with a new GUID
    /// </summary>
    public static InventoryItemBinMovementId CreateUnique()
    {
        return new InventoryItemBinMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryItemBinMovementId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryItemBinMovementId id) => id.Value;
}
}
