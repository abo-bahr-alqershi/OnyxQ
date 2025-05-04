using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Attendance.Entities;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeAttendanceLocation Entity
/// </summary>
public class EmployeeAttendanceLocation : Entity<EmployeeAttendanceLocationId>
{
    private EmployeeAttendanceLocation() { }

    /// <summary>
    /// The unique identifier for the EmployeeAttendanceLocation
    /// المعرف الفريد لـ EmployeeAttendanceLocation
    /// </summary>
    public EmployeeAttendanceLocationId Id { get; private set; }

    /// <summary>
    /// LocationNumber of the EmployeeAttendanceLocation
    /// LocationNumber الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public decimal? LocationNumber { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeAttendanceLocation
    /// EmpNo الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeAttendanceLocation
    /// InactiveFlag الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeAttendanceLocation
    /// InactiveDate الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeAttendanceLocation
    /// InactiveReason الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeAttendanceLocation
    /// InactivatedByUserId الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CreateTerminalName of the EmployeeAttendanceLocation
    /// CreateTerminalName الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public string CreateTerminalName { get; private set; }

    /// <summary>
    /// UpdateTerminalName of the EmployeeAttendanceLocation
    /// UpdateTerminalName الخاص بـ EmployeeAttendanceLocation
    /// </summary>
    public string UpdateTerminalName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralAttendanceLocation
    /// </summary>
    public GeneralAttendanceLocation GeneralAttendanceLocation { get; private set; }
    #endregion
}
}
