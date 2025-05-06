using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.Activities.ValueObjects
{
/// <summary>
/// ActivitySerialNumberDetail Identifier Value Object
/// </summary>
public sealed class ActivitySerialNumberDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ActivitySerialNumberDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ActivitySerialNumberDetailId instance
    /// </summary>
    public ActivitySerialNumberDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ActivitySerialNumberDetailId with a new GUID
    /// </summary>
    public static ActivitySerialNumberDetailId CreateUnique()
    {
        return new ActivitySerialNumberDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ActivitySerialNumberDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ActivitySerialNumberDetailId id) => id.Value;
}
}
