using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// Region Identifier Value Object
/// </summary>
public sealed class RegionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Region
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new RegionId instance
    /// </summary>
    public RegionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new RegionId with a new GUID
    /// </summary>
    public static RegionId CreateUnique()
    {
        return new RegionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(RegionId id) => id.Value.ToString();
    public static implicit operator Guid(RegionId id) => id.Value;
}
}
