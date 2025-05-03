using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a customer handheld device entity in the system.
/// يمثل كيان جهاز العميل المحمول في النظام
/// </summary>
public sealed class CustomerHandheldDevice : AggregateRoot<CustomerHandheldDeviceId>
{
    /// <summary>
    /// Gets the device name.
    /// اسم الجهاز
    /// </summary>
    public string DeviceName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether the device is inactive.
    /// يحدد ما إذا كان الجهاز غير نشط
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// Gets the inactivation date.
    /// تاريخ إلغاء التفعيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// Gets the user ID who inactivated the device.
    /// معرف المستخدم الذي قام بإلغاء تفعيل الجهاز
    /// </summary>
    public int? InactiveUserId { get; private set; }

    /// <summary>
    /// Gets the reason for inactivation.
    /// سبب إلغاء التفعيل
    /// </summary>
    public string InactiveReason { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the added user ID.
    /// معرف المستخدم الذي أضاف السجل
    /// </summary>
    public int AddedUserId { get; private set; }

    /// <summary>
    /// Gets the addition date.
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AddedDate { get; private set; }

    /// <summary>
    /// Gets the updated user ID.
    /// معرف المستخدم الذي قام بالتحديث
    /// </summary>
    public int? UpdatedUserId { get; private set; }

    /// <summary>
    /// Gets the update date.
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Navigation property for the customer.
    /// خاصية التنقل للعميل
    /// </summary>
    public Customer Customer { get; private set; }

    private CustomerHandheldDevice() { }

    private CustomerHandheldDevice(
        CustomerHandheldDeviceId id,
        string deviceName,
        int addedUserId,
        DateTime addedDate)
        : base(id)
    {
        DeviceName = deviceName;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
    }

    public static CustomerHandheldDevice Create(
        string customerCode,
        string deviceSerialNumber,
        string deviceName,
        int addedUserId)
    {
        var device = new CustomerHandheldDevice(
            CustomerHandheldDeviceId.Create(customerCode, deviceSerialNumber),
            deviceName,
            addedUserId,
            DateTime.UtcNow);

        device.RaiseDomainEvent(new CustomerHandheldDeviceCreatedEvent(device));

        return device;
    }

    public void Update(
        string deviceName,
        int updatedUserId)
    {
        DeviceName = deviceName;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;

        RaiseDomainEvent(new CustomerHandheldDeviceUpdatedEvent(this));
    }

    public void Deactivate(
        int inactiveUserId,
        string reason)
    {
        if (IsInactive)
            return;

        IsInactive = true;
        InactiveDate = DateTime.UtcNow;
        InactiveUserId = inactiveUserId;
        InactiveReason = reason;

        RaiseDomainEvent(new CustomerHandheldDeviceDeactivatedEvent(this));
    }
} 