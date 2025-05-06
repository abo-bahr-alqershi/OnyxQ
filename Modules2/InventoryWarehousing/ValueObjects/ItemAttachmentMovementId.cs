using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemAttachmentMovement Identifier Value Object
/// </summary>
public sealed class ItemAttachmentMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemAttachmentMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemAttachmentMovementId instance
    /// </summary>
    public ItemAttachmentMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemAttachmentMovementId with a new GUID
    /// </summary>
    public static ItemAttachmentMovementId CreateUnique()
    {
        return new ItemAttachmentMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemAttachmentMovementId id) => id.Value.ToString();
    public static implicit operator Guid(ItemAttachmentMovementId id) => id.Value;
}
}
