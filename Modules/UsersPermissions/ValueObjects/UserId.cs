using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// User Identifier Value Object
/// </summary>
public sealed class UserId : ValueObject
{
    /// <summary>
    /// The unique identifier for the User
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserId instance
    /// </summary>
    public UserId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserId with a new GUID
    /// </summary>
    public static UserId CreateUnique()
    {
        return new UserId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserId id) => id.Value.ToString();
    public static implicit operator Guid(UserId id) => id.Value;
}
}
