using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// CodeSendMessage Identifier Value Object
/// </summary>
public sealed class CodeSendMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CodeSendMessage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CodeSendMessageId instance
    /// </summary>
    public CodeSendMessageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CodeSendMessageId with a new GUID
    /// </summary>
    public static CodeSendMessageId CreateUnique()
    {
        return new CodeSendMessageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CodeSendMessageId id) => id.Value.ToString();
    public static implicit operator Guid(CodeSendMessageId id) => id.Value;
}
}
