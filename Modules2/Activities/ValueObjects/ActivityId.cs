using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.Activities.ValueObjects
{
/// <summary>
/// Activity Identifier Value Object
/// </summary>
public sealed class ActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Activity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ActivityId instance
    /// </summary>
    public ActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ActivityId with a new GUID
    /// </summary>
    public static ActivityId CreateUnique()
    {
        return new ActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ActivityId id) => id.Value.ToString();
    public static implicit operator Guid(ActivityId id) => id.Value;
}
}
