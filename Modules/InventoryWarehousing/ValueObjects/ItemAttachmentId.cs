using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemAttachment Identifier Value Object
/// </summary>
public sealed class ItemAttachmentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemAttachment
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemAttachmentId instance
    /// </summary>
    public ItemAttachmentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemAttachmentId with a new GUID
    /// </summary>
    public static ItemAttachmentId CreateUnique()
    {
        return new ItemAttachmentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemAttachmentId id) => id.Value.ToString();
    public static implicit operator Guid(ItemAttachmentId id) => id.Value;
}
}
