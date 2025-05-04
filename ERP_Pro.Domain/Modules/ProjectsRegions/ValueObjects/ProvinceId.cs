using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// Province Identifier Value Object
/// </summary>
public sealed class ProvinceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Province
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ProvinceId instance
    /// </summary>
    public ProvinceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ProvinceId with a new GUID
    /// </summary>
    public static ProvinceId CreateUnique()
    {
        return new ProvinceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ProvinceId id) => id.Value.ToString();
    public static implicit operator Guid(ProvinceId id) => id.Value;
}
}
