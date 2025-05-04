using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// AuditDocument Identifier Value Object
/// </summary>
public sealed class AuditDocumentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AuditDocument
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AuditDocumentId instance
    /// </summary>
    public AuditDocumentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AuditDocumentId with a new GUID
    /// </summary>
    public static AuditDocumentId CreateUnique()
    {
        return new AuditDocumentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AuditDocumentId id) => id.Value.ToString();
    public static implicit operator Guid(AuditDocumentId id) => id.Value;
}
}
