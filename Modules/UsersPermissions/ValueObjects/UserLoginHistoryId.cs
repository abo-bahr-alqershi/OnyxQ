using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserLoginHistory Identifier Value Object
/// </summary>
public sealed class UserLoginHistoryId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserLoginHistory
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserLoginHistoryId instance
    /// </summary>
    public UserLoginHistoryId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserLoginHistoryId with a new GUID
    /// </summary>
    public static UserLoginHistoryId CreateUnique()
    {
        return new UserLoginHistoryId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserLoginHistoryId id) => id.Value.ToString();
    public static implicit operator Guid(UserLoginHistoryId id) => id.Value;
}
}
