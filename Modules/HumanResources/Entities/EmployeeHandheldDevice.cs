using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeHandheldDevice Entity
/// </summary>
public class EmployeeHandheldDevice : Entity<EmployeeHandheldDeviceId>
{
    private EmployeeHandheldDevice() { }

    /// <summary>
    /// The unique identifier for the EmployeeHandheldDevice
    /// المعرف الفريد لـ EmployeeHandheldDevice
    /// </summary>
    public EmployeeHandheldDeviceId Id { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeHandheldDevice
    /// EmpNo الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// HandheldDeviceName of the EmployeeHandheldDevice
    /// HandheldDeviceName الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public string HandheldDeviceName { get; private set; }

    /// <summary>
    /// HandheldDeviceSerial of the EmployeeHandheldDevice
    /// HandheldDeviceSerial الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public string HandheldDeviceSerial { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeHandheldDevice
    /// InactiveFlag الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeHandheldDevice
    /// InactiveDate الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeHandheldDevice
    /// InactivatedByUserId الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeHandheldDevice
    /// InactiveReason الخاص بـ EmployeeHandheldDevice
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Employee
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion
}
}
