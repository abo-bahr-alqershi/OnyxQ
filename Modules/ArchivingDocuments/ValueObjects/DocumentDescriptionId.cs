using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// DocumentDescription Identifier Value Object
/// </summary>
public sealed class DocumentDescriptionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DocumentDescription
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DocumentDescriptionId instance
    /// </summary>
    public DocumentDescriptionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DocumentDescriptionId with a new GUID
    /// </summary>
    public static DocumentDescriptionId CreateUnique()
    {
        return new DocumentDescriptionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DocumentDescriptionId id) => id.Value.ToString();
    public static implicit operator Guid(DocumentDescriptionId id) => id.Value;
}
}
