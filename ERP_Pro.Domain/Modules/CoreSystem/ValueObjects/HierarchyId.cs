using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// Hierarchy Identifier Value Object
/// </summary>
public sealed class HierarchyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Hierarchy
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new HierarchyId instance
    /// </summary>
    public HierarchyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new HierarchyId with a new GUID
    /// </summary>
    public static HierarchyId CreateUnique()
    {
        return new HierarchyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(HierarchyId id) => id.Value.ToString();
    public static implicit operator Guid(HierarchyId id) => id.Value;
}
}
