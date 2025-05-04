using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// OtherItemAttachment Identifier Value Object
/// </summary>
public sealed class OtherItemAttachmentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OtherItemAttachment
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OtherItemAttachmentId instance
    /// </summary>
    public OtherItemAttachmentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OtherItemAttachmentId with a new GUID
    /// </summary>
    public static OtherItemAttachmentId CreateUnique()
    {
        return new OtherItemAttachmentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OtherItemAttachmentId id) => id.Value.ToString();
    public static implicit operator Guid(OtherItemAttachmentId id) => id.Value;
}
}
