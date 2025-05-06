using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects
{
/// <summary>
/// RouteMaster Identifier Value Object
/// </summary>
public sealed class RouteMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the RouteMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RouteMasterId instance
    /// </summary>
    public RouteMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RouteMasterId with a new GUID
    /// </summary>
    public static RouteMasterId CreateUnique()
    {
        return new RouteMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RouteMasterId id) => id.Value.ToString();
    public static implicit operator Guid(RouteMasterId id) => id.Value;
}
}
