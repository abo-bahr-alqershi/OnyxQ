using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GroupItemLevelTree Identifier Value Object
/// </summary>
public sealed class GroupItemLevelTreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GroupItemLevelTree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GroupItemLevelTreeId instance
    /// </summary>
    public GroupItemLevelTreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GroupItemLevelTreeId with a new GUID
    /// </summary>
    public static GroupItemLevelTreeId CreateUnique()
    {
        return new GroupItemLevelTreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GroupItemLevelTreeId id) => id.Value.ToString();
    public static implicit operator Guid(GroupItemLevelTreeId id) => id.Value;
}
}
