using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// SequenceControl Identifier Value Object
/// </summary>
public sealed class SequenceControlId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SequenceControl
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SequenceControlId instance
    /// </summary>
    public SequenceControlId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SequenceControlId with a new GUID
    /// </summary>
    public static SequenceControlId CreateUnique()
    {
        return new SequenceControlId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SequenceControlId id) => id.Value.ToString();
    public static implicit operator Guid(SequenceControlId id) => id.Value;
}
}
