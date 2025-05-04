using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// AttachmentMaster Identifier Value Object
/// </summary>
public sealed class AttachmentMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AttachmentMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AttachmentMasterId instance
    /// </summary>
    public AttachmentMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AttachmentMasterId with a new GUID
    /// </summary>
    public static AttachmentMasterId CreateUnique()
    {
        return new AttachmentMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AttachmentMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AttachmentMasterId id) => id.Value;
}
}
