using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects
{
/// <summary>
/// FormFieldPrivilege Identifier Value Object
/// </summary>
public sealed class FormFieldPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FormFieldPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FormFieldPrivilegeId instance
    /// </summary>
    public FormFieldPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FormFieldPrivilegeId with a new GUID
    /// </summary>
    public static FormFieldPrivilegeId CreateUnique()
    {
        return new FormFieldPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FormFieldPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(FormFieldPrivilegeId id) => id.Value;
}
}
