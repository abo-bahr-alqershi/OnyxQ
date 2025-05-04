using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// UserHandheldDevice Entity
/// </summary>
public class UserHandheldDevice : Entity<UserHandheldDeviceId>
{
    private UserHandheldDevice() { }

    /// <summary>
    /// The unique identifier for the UserHandheldDevice
    /// المعرف الفريد لـ UserHandheldDevice
    /// </summary>
    public UserHandheldDeviceId Id { get; private set; }

    /// <summary>
    /// UserId of the UserHandheldDevice
    /// UserId الخاص بـ UserHandheldDevice
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// HandheldDeviceName of the UserHandheldDevice
    /// HandheldDeviceName الخاص بـ UserHandheldDevice
    /// </summary>
    public string HandheldDeviceName { get; private set; }

    /// <summary>
    /// HandheldDeviceSerial of the UserHandheldDevice
    /// HandheldDeviceSerial الخاص بـ UserHandheldDevice
    /// </summary>
    public string HandheldDeviceSerial { get; private set; }

    /// <summary>
    /// InactiveFlag of the UserHandheldDevice
    /// InactiveFlag الخاص بـ UserHandheldDevice
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the UserHandheldDevice
    /// InactiveDate الخاص بـ UserHandheldDevice
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the UserHandheldDevice
    /// InactivatedByUserId الخاص بـ UserHandheldDevice
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the UserHandheldDevice
    /// InactiveReason الخاص بـ UserHandheldDevice
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
