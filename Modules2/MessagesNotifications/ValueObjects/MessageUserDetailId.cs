using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// MessageUserDetail Identifier Value Object
/// </summary>
public sealed class MessageUserDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the MessageUserDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MessageUserDetailId instance
    /// </summary>
    public MessageUserDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MessageUserDetailId with a new GUID
    /// </summary>
    public static MessageUserDetailId CreateUnique()
    {
        return new MessageUserDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MessageUserDetailId id) => id.Value.ToString();
    public static implicit operator Guid(MessageUserDetailId id) => id.Value;
}
}
