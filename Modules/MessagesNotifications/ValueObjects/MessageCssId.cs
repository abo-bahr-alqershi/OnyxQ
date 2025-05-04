using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// MessageCss Identifier Value Object
/// </summary>
public sealed class MessageCssId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MessageCss
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MessageCssId instance
    /// </summary>
    public MessageCssId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MessageCssId with a new GUID
    /// </summary>
    public static MessageCssId CreateUnique()
    {
        return new MessageCssId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MessageCssId id) => id.Value.ToString();
    public static implicit operator Guid(MessageCssId id) => id.Value;
}
}
