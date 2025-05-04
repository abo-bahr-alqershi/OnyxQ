using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// MessageSmsDetail Identifier Value Object
/// </summary>
public sealed class MessageSmsDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MessageSmsDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MessageSmsDetailId instance
    /// </summary>
    public MessageSmsDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MessageSmsDetailId with a new GUID
    /// </summary>
    public static MessageSmsDetailId CreateUnique()
    {
        return new MessageSmsDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MessageSmsDetailId id) => id.Value.ToString();
    public static implicit operator Guid(MessageSmsDetailId id) => id.Value;
}
}
