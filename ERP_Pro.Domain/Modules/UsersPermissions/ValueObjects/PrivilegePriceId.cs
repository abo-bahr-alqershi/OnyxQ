using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegePrice Identifier Value Object
/// </summary>
public sealed class PrivilegePriceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegePrice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegePriceId instance
    /// </summary>
    public PrivilegePriceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegePriceId with a new GUID
    /// </summary>
    public static PrivilegePriceId CreateUnique()
    {
        return new PrivilegePriceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegePriceId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegePriceId id) => id.Value;
}
}
