using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovedLevel Identifier Value Object
/// </summary>
public sealed class ApprovedLevelId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovedLevel
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovedLevelId instance
    /// </summary>
    public ApprovedLevelId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovedLevelId with a new GUID
    /// </summary>
    public static ApprovedLevelId CreateUnique()
    {
        return new ApprovedLevelId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovedLevelId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovedLevelId id) => id.Value;
}
}
