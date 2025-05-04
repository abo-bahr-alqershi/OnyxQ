using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.Activities.ValueObjects
{
/// <summary>
/// ActivityGroup Identifier Value Object
/// </summary>
public sealed class ActivityGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ActivityGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ActivityGroupId instance
    /// </summary>
    public ActivityGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ActivityGroupId with a new GUID
    /// </summary>
    public static ActivityGroupId CreateUnique()
    {
        return new ActivityGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ActivityGroupId id) => id.Value.ToString();
    public static implicit operator Guid(ActivityGroupId id) => id.Value;
}
}
