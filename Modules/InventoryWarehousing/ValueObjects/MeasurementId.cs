using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// Measurement Identifier Value Object
/// </summary>
public sealed class MeasurementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Measurement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new MeasurementId instance
    /// </summary>
    public MeasurementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new MeasurementId with a new GUID
    /// </summary>
    public static MeasurementId CreateUnique()
    {
        return new MeasurementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(MeasurementId id) => id.Value.ToString();
    public static implicit operator Guid(MeasurementId id) => id.Value;
}
}
