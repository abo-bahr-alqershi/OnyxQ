using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// HierarchyType Identifier Value Object
/// </summary>
public sealed class HierarchyTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the HierarchyType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new HierarchyTypeId instance
    /// </summary>
    public HierarchyTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new HierarchyTypeId with a new GUID
    /// </summary>
    public static HierarchyTypeId CreateUnique()
    {
        return new HierarchyTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(HierarchyTypeId id) => id.Value.ToString();
    public static implicit operator Guid(HierarchyTypeId id) => id.Value;
}
}
