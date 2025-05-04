using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// GpsEvent Identifier Value Object
/// </summary>
public sealed class GpsEventId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GpsEvent
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GpsEventId instance
    /// </summary>
    public GpsEventId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GpsEventId with a new GUID
    /// </summary>
    public static GpsEventId CreateUnique()
    {
        return new GpsEventId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GpsEventId id) => id.Value.ToString();
    public static implicit operator Guid(GpsEventId id) => id.Value;
}
}
