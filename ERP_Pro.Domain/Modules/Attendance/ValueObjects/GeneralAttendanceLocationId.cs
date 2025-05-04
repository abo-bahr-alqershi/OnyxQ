using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.Attendance.ValueObjects
{
/// <summary>
/// GeneralAttendanceLocation Identifier Value Object
/// </summary>
public sealed class GeneralAttendanceLocationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GeneralAttendanceLocation
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GeneralAttendanceLocationId instance
    /// </summary>
    public GeneralAttendanceLocationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GeneralAttendanceLocationId with a new GUID
    /// </summary>
    public static GeneralAttendanceLocationId CreateUnique()
    {
        return new GeneralAttendanceLocationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GeneralAttendanceLocationId id) => id.Value.ToString();
    public static implicit operator Guid(GeneralAttendanceLocationId id) => id.Value;
}
}
