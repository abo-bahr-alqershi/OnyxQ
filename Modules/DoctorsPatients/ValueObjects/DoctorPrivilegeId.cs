using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.ValueObjects
{
/// <summary>
/// DoctorPrivilege Identifier Value Object
/// </summary>
public sealed class DoctorPrivilegeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DoctorPrivilege
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DoctorPrivilegeId instance
    /// </summary>
    public DoctorPrivilegeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DoctorPrivilegeId with a new GUID
    /// </summary>
    public static DoctorPrivilegeId CreateUnique()
    {
        return new DoctorPrivilegeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DoctorPrivilegeId id) => id.Value.ToString();
    public static implicit operator Guid(DoctorPrivilegeId id) => id.Value;
}
}
