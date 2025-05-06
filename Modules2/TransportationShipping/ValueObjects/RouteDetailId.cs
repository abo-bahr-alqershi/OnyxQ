using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects
{
/// <summary>
/// RouteDetail Identifier Value Object
/// </summary>
public sealed class RouteDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RouteDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RouteDetailId instance
    /// </summary>
    public RouteDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RouteDetailId with a new GUID
    /// </summary>
    public static RouteDetailId CreateUnique()
    {
        return new RouteDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RouteDetailId id) => id.Value.ToString();
    public static implicit operator Guid(RouteDetailId id) => id.Value;
}
}
