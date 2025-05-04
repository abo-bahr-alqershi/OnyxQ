using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserHead Identifier Value Object
/// </summary>
public sealed class UserHeadId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserHead
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserHeadId instance
    /// </summary>
    public UserHeadId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserHeadId with a new GUID
    /// </summary>
    public static UserHeadId CreateUnique()
    {
        return new UserHeadId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserHeadId id) => id.Value.ToString();
    public static implicit operator Guid(UserHeadId id) => id.Value;
}
}
