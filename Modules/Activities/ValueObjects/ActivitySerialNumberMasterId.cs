using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.Activities.ValueObjects
{
/// <summary>
/// ActivitySerialNumberMaster Identifier Value Object
/// </summary>
public sealed class ActivitySerialNumberMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ActivitySerialNumberMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ActivitySerialNumberMasterId instance
    /// </summary>
    public ActivitySerialNumberMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ActivitySerialNumberMasterId with a new GUID
    /// </summary>
    public static ActivitySerialNumberMasterId CreateUnique()
    {
        return new ActivitySerialNumberMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ActivitySerialNumberMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ActivitySerialNumberMasterId id) => id.Value;
}
}
