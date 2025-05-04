using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects
{
/// <summary>
/// ParaCss Identifier Value Object
/// </summary>
public sealed class ParaCssId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParaCss
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParaCssId instance
    /// </summary>
    public ParaCssId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParaCssId with a new GUID
    /// </summary>
    public static ParaCssId CreateUnique()
    {
        return new ParaCssId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParaCssId id) => id.Value.ToString();
    public static implicit operator Guid(ParaCssId id) => id.Value;
}
}
