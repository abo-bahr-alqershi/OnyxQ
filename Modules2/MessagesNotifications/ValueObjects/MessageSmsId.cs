using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// MessageSms Identifier Value Object
/// </summary>
public sealed class MessageSmsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MessageSms
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MessageSmsId instance
    /// </summary>
    public MessageSmsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MessageSmsId with a new GUID
    /// </summary>
    public static MessageSmsId CreateUnique()
    {
        return new MessageSmsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MessageSmsId id) => id.Value.ToString();
    public static implicit operator Guid(MessageSmsId id) => id.Value;
}
}
