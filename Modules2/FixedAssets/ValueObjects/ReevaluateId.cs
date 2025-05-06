using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FixedAssets.ValueObjects
{
/// <summary>
/// Reevaluate Identifier Value Object
/// </summary>
public sealed class ReevaluateId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Reevaluate
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReevaluateId instance
    /// </summary>
    public ReevaluateId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReevaluateId with a new GUID
    /// </summary>
    public static ReevaluateId CreateUnique()
    {
        return new ReevaluateId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReevaluateId id) => id.Value.ToString();
    public static implicit operator Guid(ReevaluateId id) => id.Value;
}
}
