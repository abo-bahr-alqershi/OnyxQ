using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Represents the event raised when a customer handheld device is created.
/// حدث يتم رفعه عند إنشاء جهاز محمول للعميل
/// </summary>
public sealed record CustomerHandheldDeviceCreatedEvent(CustomerHandheldDevice CustomerHandheldDevice) : IDomainEvent;

/// <summary>
/// Represents the event raised when a customer handheld device is updated.
/// حدث يتم رفعه عند تحديث جهاز محمول للعميل
/// </summary>
public sealed record CustomerHandheldDeviceUpdatedEvent(CustomerHandheldDevice CustomerHandheldDevice) : IDomainEvent;

/// <summary>
/// Represents the event raised when a customer handheld device is deactivated.
/// حدث يتم رفعه عند إلغاء تفعيل جهاز محمول للعميل
/// </summary>
public sealed record CustomerHandheldDeviceDeactivatedEvent(CustomerHandheldDevice CustomerHandheldDevice) : IDomainEvent; 