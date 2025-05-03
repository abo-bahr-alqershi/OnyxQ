using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new mobile screen is created
/// حدث يتم رفعه عند إنشاء شاشة موبايل جديدة
/// </summary>
public class MobileScreenCreatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen
    /// شاشة الموبايل
    /// </summary>
    public MobileScreen Screen { get; }

    public MobileScreenCreatedEvent(MobileScreen screen)
    {
        Screen = screen;
    }
}

/// <summary>
/// Event raised when a mobile screen status is updated
/// حدث يتم رفعه عند تحديث حالة شاشة الموبايل
/// </summary>
public class MobileScreenStatusUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen
    /// شاشة الموبايل
    /// </summary>
    public MobileScreen Screen { get; }

    public MobileScreenStatusUpdatedEvent(MobileScreen screen)
    {
        Screen = screen;
    }
}

/// <summary>
/// Event raised when a mobile screen order is updated
/// حدث يتم رفعه عند تحديث ترتيب شاشة الموبايل
/// </summary>
public class MobileScreenOrderUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen
    /// شاشة الموبايل
    /// </summary>
    public MobileScreen Screen { get; }

    public MobileScreenOrderUpdatedEvent(MobileScreen screen)
    {
        Screen = screen;
    }
}

/// <summary>
/// Event raised when a name is added to a mobile screen
/// حدث يتم رفعه عند إضافة اسم لشاشة الموبايل
/// </summary>
public class MobileScreenNameAddedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen
    /// شاشة الموبايل
    /// </summary>
    public MobileScreen Screen { get; }

    /// <summary>
    /// Gets the screen name
    /// اسم الشاشة
    /// </summary>
    public MobileScreenName ScreenName { get; }

    public MobileScreenNameAddedEvent(MobileScreen screen, MobileScreenName screenName)
    {
        Screen = screen;
        ScreenName = screenName;
    }
}

/// <summary>
/// Event raised when a privilege is added to a mobile screen
/// حدث يتم رفعه عند إضافة صلاحية لشاشة الموبايل
/// </summary>
public class MobileScreenPrivilegeAddedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen
    /// شاشة الموبايل
    /// </summary>
    public MobileScreen Screen { get; }

    /// <summary>
    /// Gets the screen privilege
    /// صلاحية الشاشة
    /// </summary>
    public MobileScreenPrivilege Privilege { get; }

    public MobileScreenPrivilegeAddedEvent(MobileScreen screen, MobileScreenPrivilege privilege)
    {
        Screen = screen;
        Privilege = privilege;
    }
} 