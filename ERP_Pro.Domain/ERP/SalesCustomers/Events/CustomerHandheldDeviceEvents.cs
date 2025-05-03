using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events;

/// <summary>
/// Event raised when a customer handheld device is created
/// حدث يتم رفعه عند إنشاء جهاز يد العميل
/// </summary>
public class CustomerHandheldDeviceCreatedEvent : DomainEvent
{
    public CustomerHandheldDevice Device { get; }

    public CustomerHandheldDeviceCreatedEvent(CustomerHandheldDevice device)
    {
        Device = device;
    }
}

/// <summary>
/// Event raised when a customer handheld device is updated
/// حدث يتم رفعه عند تحديث جهاز يد العميل
/// </summary>
public class CustomerHandheldDeviceUpdatedEvent : DomainEvent
{
    public CustomerHandheldDevice Device { get; }

    public CustomerHandheldDeviceUpdatedEvent(CustomerHandheldDevice device)
    {
        Device = device;
    }
}

/// <summary>
/// Event raised when a customer handheld device is deactivated
/// حدث يتم رفعه عند إلغاء تفعيل جهاز يد العميل
/// </summary>
public class CustomerHandheldDeviceDeactivatedEvent : DomainEvent
{
    public CustomerHandheldDevice Device { get; }

    public CustomerHandheldDeviceDeactivatedEvent(CustomerHandheldDevice device)
    {
        Device = device;
    }
}

/// <summary>
/// Event raised when a customer handheld device is activated
/// حدث يتم رفعه عند تفعيل جهاز يد العميل
/// </summary>
public class CustomerHandheldDeviceActivatedEvent : DomainEvent
{
    public CustomerHandheldDevice Device { get; }

    public CustomerHandheldDeviceActivatedEvent(CustomerHandheldDevice device)
    {
        Device = device;
    }
} 