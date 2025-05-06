using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeAttendanceLocation Identifier Value Object
/// </summary>
public sealed class EmployeeAttendanceLocationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeAttendanceLocation
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeAttendanceLocationId instance
    /// </summary>
    public EmployeeAttendanceLocationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeAttendanceLocationId with a new GUID
    /// </summary>
    public static EmployeeAttendanceLocationId CreateUnique()
    {
        return new EmployeeAttendanceLocationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeAttendanceLocationId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeAttendanceLocationId id) => id.Value;
}
}
