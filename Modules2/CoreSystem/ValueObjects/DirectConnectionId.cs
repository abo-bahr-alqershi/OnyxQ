using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// DirectConnection Identifier Value Object
/// </summary>
public sealed class DirectConnectionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DirectConnection
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DirectConnectionId instance
    /// </summary>
    public DirectConnectionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DirectConnectionId with a new GUID
    /// </summary>
    public static DirectConnectionId CreateUnique()
    {
        return new DirectConnectionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DirectConnectionId id) => id.Value.ToString();
    public static implicit operator Guid(DirectConnectionId id) => id.Value;
}
}
