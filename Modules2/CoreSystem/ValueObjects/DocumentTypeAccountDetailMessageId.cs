using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// DocumentTypeAccountDetailMessage Identifier Value Object
/// </summary>
public sealed class DocumentTypeAccountDetailMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DocumentTypeAccountDetailMessage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DocumentTypeAccountDetailMessageId instance
    /// </summary>
    public DocumentTypeAccountDetailMessageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DocumentTypeAccountDetailMessageId with a new GUID
    /// </summary>
    public static DocumentTypeAccountDetailMessageId CreateUnique()
    {
        return new DocumentTypeAccountDetailMessageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DocumentTypeAccountDetailMessageId id) => id.Value.ToString();
    public static implicit operator Guid(DocumentTypeAccountDetailMessageId id) => id.Value;
}
}
