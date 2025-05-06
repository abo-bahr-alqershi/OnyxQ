using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// PrivilegeCustomer Identifier Value Object
/// </summary>
public sealed class PrivilegeCustomerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PrivilegeCustomer
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PrivilegeCustomerId instance
    /// </summary>
    public PrivilegeCustomerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PrivilegeCustomerId with a new GUID
    /// </summary>
    public static PrivilegeCustomerId CreateUnique()
    {
        return new PrivilegeCustomerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PrivilegeCustomerId id) => id.Value.ToString();
    public static implicit operator Guid(PrivilegeCustomerId id) => id.Value;
}
}
