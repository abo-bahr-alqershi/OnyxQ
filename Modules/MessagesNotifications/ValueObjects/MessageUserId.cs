using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// MessageUser Identifier Value Object
/// </summary>
public sealed class MessageUserId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MessageUser
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MessageUserId instance
    /// </summary>
    public MessageUserId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MessageUserId with a new GUID
    /// </summary>
    public static MessageUserId CreateUnique()
    {
        return new MessageUserId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MessageUserId id) => id.Value.ToString();
    public static implicit operator Guid(MessageUserId id) => id.Value;
}
}
