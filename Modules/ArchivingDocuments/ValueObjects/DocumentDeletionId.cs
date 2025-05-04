using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// DocumentDeletion Identifier Value Object
/// </summary>
public sealed class DocumentDeletionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DocumentDeletion
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DocumentDeletionId instance
    /// </summary>
    public DocumentDeletionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DocumentDeletionId with a new GUID
    /// </summary>
    public static DocumentDeletionId CreateUnique()
    {
        return new DocumentDeletionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DocumentDeletionId id) => id.Value.ToString();
    public static implicit operator Guid(DocumentDeletionId id) => id.Value;
}
}
