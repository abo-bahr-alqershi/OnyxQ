using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.SalesCustomers.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities;

/// <summary>
/// Represents a customer's handheld device
/// يمثل جهاز يد العميل
/// </summary>
public class CustomerHandheldDevice : AuditableEntity
{
    /// <summary>
    /// The composite ID for the device (CustomerCode + DeviceSerialNumber)
    /// المعرف المركب للجهاز (رمز العميل + الرقم التسلسلي للجهاز)
    /// </summary>
    public CustomerHandheldDeviceId Id { get; private set; }

    /// <summary>
    /// The device name
    /// اسم الجهاز
    /// </summary>
    public string DeviceName { get; private set; }

    /// <summary>
    /// The device serial number
    /// الرقم التسلسلي للجهاز
    /// </summary>
    public string DeviceSerialNumber { get; private set; }

    /// <summary>
    /// Whether the device is inactive
    /// ما إذا كان الجهاز غير نشط
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// The customer code this device belongs to
    /// رمز العميل الذي يملك هذا الجهاز
    /// </summary>
    public string CustomerCode { get; private set; }

    /// <summary>
    /// Navigation property for the customer relationship
    /// خاصية التنقل لعلاقة العميل
    /// </summary>
    public Customer Customer { get; private set; }

    private CustomerHandheldDevice() { } // For EF Core

    public CustomerHandheldDevice(
        string customerCode,
        string deviceName,
        string deviceSerialNumber)
    {
        Id = new CustomerHandheldDeviceId(customerCode, deviceSerialNumber);
        CustomerCode = customerCode;
        DeviceName = deviceName;
        DeviceSerialNumber = deviceSerialNumber;
        IsInactive = false;

        AddDomainEvent(new CustomerHandheldDeviceCreatedEvent(this));
    }

    public void Update(string deviceName)
    {
        DeviceName = deviceName;
        AddDomainEvent(new CustomerHandheldDeviceUpdatedEvent(this));
    }

    public void Deactivate()
    {
        if (!IsInactive)
        {
            IsInactive = true;
            AddDomainEvent(new CustomerHandheldDeviceDeactivatedEvent(this));
        }
    }

    public void Activate()
    {
        if (IsInactive)
        {
            IsInactive = false;
            AddDomainEvent(new CustomerHandheldDeviceActivatedEvent(this));
        }
    }
} 