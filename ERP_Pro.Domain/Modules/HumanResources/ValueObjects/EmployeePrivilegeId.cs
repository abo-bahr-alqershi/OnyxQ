using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeePrivilege Identifier Value Object
/// </summary>
public sealed class EmployeePrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeePrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeePrivilegeId instance
    /// </summary>
    public EmployeePrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeePrivilegeId with a new GUID
    /// </summary>
    public static EmployeePrivilegeId CreateUnique()
    {
        return new EmployeePrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeePrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeePrivilegeId id) => id.Value;
}
}
