using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemRequirement Identifier Value Object
/// </summary>
public sealed class ItemRequirementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemRequirement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemRequirementId instance
    /// </summary>
    public ItemRequirementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemRequirementId with a new GUID
    /// </summary>
    public static ItemRequirementId CreateUnique()
    {
        return new ItemRequirementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemRequirementId id) => id.Value.ToString();
    public static implicit operator Guid(ItemRequirementId id) => id.Value;
}
}
