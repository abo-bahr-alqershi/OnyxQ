using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// AttachmentDetail Identifier Value Object
/// </summary>
public sealed class AttachmentDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AttachmentDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AttachmentDetailId instance
    /// </summary>
    public AttachmentDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AttachmentDetailId with a new GUID
    /// </summary>
    public static AttachmentDetailId CreateUnique()
    {
        return new AttachmentDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AttachmentDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AttachmentDetailId id) => id.Value;
}
}
