using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects
{
/// <summary>
/// GroupDetail Identifier Value Object
/// </summary>
public sealed class GroupDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GroupDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GroupDetailId instance
    /// </summary>
    public GroupDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GroupDetailId with a new GUID
    /// </summary>
    public static GroupDetailId CreateUnique()
    {
        return new GroupDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GroupDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GroupDetailId id) => id.Value;
}
}
