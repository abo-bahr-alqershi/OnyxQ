using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ParameterMessage Identifier Value Object
/// </summary>
public sealed class ParameterMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ParameterMessage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ParameterMessageId instance
    /// </summary>
    public ParameterMessageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ParameterMessageId with a new GUID
    /// </summary>
    public static ParameterMessageId CreateUnique()
    {
        return new ParameterMessageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ParameterMessageId id) => id.Value.ToString();
    public static implicit operator Guid(ParameterMessageId id) => id.Value;
}
}
