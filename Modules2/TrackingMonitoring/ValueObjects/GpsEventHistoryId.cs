using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects
{
/// <summary>
/// GpsEventHistory Identifier Value Object
/// </summary>
public sealed class GpsEventHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GpsEventHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GpsEventHistoryId instance
    /// </summary>
    public GpsEventHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GpsEventHistoryId with a new GUID
    /// </summary>
    public static GpsEventHistoryId CreateUnique()
    {
        return new GpsEventHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GpsEventHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(GpsEventHistoryId id) => id.Value;
}
}
