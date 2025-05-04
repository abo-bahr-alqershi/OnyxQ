using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// GeneralCodePrivilege Identifier Value Object
/// </summary>
public sealed class GeneralCodePrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralCodePrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralCodePrivilegeId instance
    /// </summary>
    public GeneralCodePrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralCodePrivilegeId with a new GUID
    /// </summary>
    public static GeneralCodePrivilegeId CreateUnique()
    {
        return new GeneralCodePrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralCodePrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralCodePrivilegeId id) => id.Value;
}
}
