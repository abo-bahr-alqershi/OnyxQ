using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.Attendance.Entities
{
/// <summary>
/// GeneralAttendanceLocation Entity
/// </summary>
public class GeneralAttendanceLocation : Entity<GeneralAttendanceLocationId>
{
    private GeneralAttendanceLocation() { }

    /// <summary>
    /// The unique identifier for the GeneralAttendanceLocation
    /// المعرف الفريد لـ GeneralAttendanceLocation
    /// </summary>
    public GeneralAttendanceLocationId Id { get; private set; }

    /// <summary>
    /// LocationNumber of the GeneralAttendanceLocation
    /// LocationNumber الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public decimal? LocationNumber { get; private set; }

    /// <summary>
    /// LocationLastName of the GeneralAttendanceLocation
    /// LocationLastName الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public string LocationLastName { get; private set; }

    /// <summary>
    /// LocationFirstName of the GeneralAttendanceLocation
    /// LocationFirstName الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public string LocationFirstName { get; private set; }

    /// <summary>
    /// ConnectionTypeShort of the GeneralAttendanceLocation
    /// ConnectionTypeShort الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public decimal? ConnectionTypeShort { get; private set; }

    /// <summary>
    /// GpsLongitudeX of the GeneralAttendanceLocation
    /// GpsLongitudeX الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public string GpsLongitudeX { get; private set; }

    /// <summary>
    /// GpsLatitudeY of the GeneralAttendanceLocation
    /// GpsLatitudeY الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public string GpsLatitudeY { get; private set; }

    /// <summary>
    /// AllowDistanceGps of the GeneralAttendanceLocation
    /// AllowDistanceGps الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public decimal? AllowDistanceGps { get; private set; }

    /// <summary>
    /// LocationNetworkIp of the GeneralAttendanceLocation
    /// LocationNetworkIp الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public string LocationNetworkIp { get; private set; }

    /// <summary>
    /// InactiveFlag of the GeneralAttendanceLocation
    /// InactiveFlag الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the GeneralAttendanceLocation
    /// InactiveReason الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the GeneralAttendanceLocation
    /// InactivatedByUserId الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the GeneralAttendanceLocation
    /// InactiveDate الخاص بـ GeneralAttendanceLocation
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: GeneralAttendanceLocation to EmployeeAttendanceLocation
    /// </summary>
    public IReadOnlyCollection<EmployeeAttendanceLocation> EmployeeAttendanceLocations { get; private set; }
    /// <summary>
    /// One-to-many relationship: GeneralAttendanceLocation to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    #endregion
}
}
