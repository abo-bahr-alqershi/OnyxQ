using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// CustomerHandheldDevice Entity
/// </summary>
public class CustomerHandheldDevice : Entity<CustomerHandheldDeviceId>
{
    private CustomerHandheldDevice() { }

    /// <summary>
    /// The unique identifier for the CustomerHandheldDevice
    /// المعرف الفريد لـ CustomerHandheldDevice
    /// </summary>
    public CustomerHandheldDeviceId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerHandheldDevice
    /// CCode الخاص بـ CustomerHandheldDevice
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// HandheldDeviceName of the CustomerHandheldDevice
    /// HandheldDeviceName الخاص بـ CustomerHandheldDevice
    /// </summary>
    public string HandheldDeviceName { get; private set; }

    /// <summary>
    /// HandheldDeviceSerial of the CustomerHandheldDevice
    /// HandheldDeviceSerial الخاص بـ CustomerHandheldDevice
    /// </summary>
    public string HandheldDeviceSerial { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerHandheldDevice
    /// InactiveFlag الخاص بـ CustomerHandheldDevice
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the CustomerHandheldDevice
    /// InactiveDate الخاص بـ CustomerHandheldDevice
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CustomerHandheldDevice
    /// InactivatedByUserId الخاص بـ CustomerHandheldDevice
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the CustomerHandheldDevice
    /// InactiveReason الخاص بـ CustomerHandheldDevice
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
