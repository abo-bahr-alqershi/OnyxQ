using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FixedAssets.ValueObjects
{
/// <summary>
/// Revaluation Identifier Value Object
/// </summary>
public sealed class RevaluationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Revaluation
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RevaluationId instance
    /// </summary>
    public RevaluationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RevaluationId with a new GUID
    /// </summary>
    public static RevaluationId CreateUnique()
    {
        return new RevaluationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RevaluationId id) => id.Value.ToString();
    public static implicit operator Guid(RevaluationId id) => id.Value;
}
}
