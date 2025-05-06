using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SequenceValue Identifier Value Object
/// </summary>
public sealed class SequenceValueId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SequenceValue
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SequenceValueId instance
    /// </summary>
    public SequenceValueId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SequenceValueId with a new GUID
    /// </summary>
    public static SequenceValueId CreateUnique()
    {
        return new SequenceValueId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SequenceValueId id) => id.Value.ToString();
    public static implicit operator Guid(SequenceValueId id) => id.Value;
}
}
