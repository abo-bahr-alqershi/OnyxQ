using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// DocumentTypeMessage Identifier Value Object
/// </summary>
public sealed class DocumentTypeMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DocumentTypeMessage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DocumentTypeMessageId instance
    /// </summary>
    public DocumentTypeMessageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DocumentTypeMessageId with a new GUID
    /// </summary>
    public static DocumentTypeMessageId CreateUnique()
    {
        return new DocumentTypeMessageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DocumentTypeMessageId id) => id.Value.ToString();
    public static implicit operator Guid(DocumentTypeMessageId id) => id.Value;
}
}
