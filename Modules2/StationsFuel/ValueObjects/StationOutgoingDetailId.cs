using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.StationsFuel.ValueObjects
{
/// <summary>
/// StationOutgoingDetail Identifier Value Object
/// </summary>
public sealed class StationOutgoingDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the StationOutgoingDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new StationOutgoingDetailId instance
    /// </summary>
    public StationOutgoingDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new StationOutgoingDetailId with a new GUID
    /// </summary>
    public static StationOutgoingDetailId CreateUnique()
    {
        return new StationOutgoingDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(StationOutgoingDetailId id) => id.Value.ToString();
    public static implicit operator Guid(StationOutgoingDetailId id) => id.Value;
}
}
