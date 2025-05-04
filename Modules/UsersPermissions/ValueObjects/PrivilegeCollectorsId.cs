using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeCollectors Identifier Value Object
/// </summary>
public sealed class PrivilegeCollectorsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeCollectors
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeCollectorsId instance
    /// </summary>
    public PrivilegeCollectorsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeCollectorsId with a new GUID
    /// </summary>
    public static PrivilegeCollectorsId CreateUnique()
    {
        return new PrivilegeCollectorsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeCollectorsId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeCollectorsId id) => id.Value;
}
}
