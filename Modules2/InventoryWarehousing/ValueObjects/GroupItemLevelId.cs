using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GroupItemLevel Identifier Value Object
/// </summary>
public sealed class GroupItemLevelId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GroupItemLevel
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GroupItemLevelId instance
    /// </summary>
    public GroupItemLevelId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GroupItemLevelId with a new GUID
    /// </summary>
    public static GroupItemLevelId CreateUnique()
    {
        return new GroupItemLevelId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GroupItemLevelId id) => id.Value.ToString();
    public static implicit operator Guid(GroupItemLevelId id) => id.Value;
}
}
