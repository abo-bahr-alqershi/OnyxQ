using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.Activities.ValueObjects
{
/// <summary>
/// ActivityTree Identifier Value Object
/// </summary>
public sealed class ActivityTreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ActivityTree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ActivityTreeId instance
    /// </summary>
    public ActivityTreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ActivityTreeId with a new GUID
    /// </summary>
    public static ActivityTreeId CreateUnique()
    {
        return new ActivityTreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ActivityTreeId id) => id.Value.ToString();
    public static implicit operator Guid(ActivityTreeId id) => id.Value;
}
}
