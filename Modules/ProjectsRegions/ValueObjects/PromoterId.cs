using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects
{
/// <summary>
/// Promoter Identifier Value Object
/// </summary>
public sealed class PromoterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Promoter
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PromoterId instance
    /// </summary>
    public PromoterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PromoterId with a new GUID
    /// </summary>
    public static PromoterId CreateUnique()
    {
        return new PromoterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PromoterId id) => id.Value.ToString();
    public static implicit operator Guid(PromoterId id) => id.Value;
}
}
