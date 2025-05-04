using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// City Identifier Value Object
/// </summary>
public sealed class CityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the City
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CityId instance
    /// </summary>
    public CityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CityId with a new GUID
    /// </summary>
    public static CityId CreateUnique()
    {
        return new CityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CityId id) => id.Value.ToString();
    public static implicit operator Guid(CityId id) => id.Value;
}
}
