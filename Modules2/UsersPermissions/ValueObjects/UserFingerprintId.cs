using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// UserFingerprint Identifier Value Object
/// </summary>
public sealed class UserFingerprintId : ValueObject
{
    /// <summary>
    /// The unique identifier for the UserFingerprint
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new UserFingerprintId instance
    /// </summary>
    public UserFingerprintId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new UserFingerprintId with a new GUID
    /// </summary>
    public static UserFingerprintId CreateUnique()
    {
        return new UserFingerprintId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(UserFingerprintId id) => id.Value.ToString();
    public static implicit operator Guid(UserFingerprintId id) => id.Value;
}
}
