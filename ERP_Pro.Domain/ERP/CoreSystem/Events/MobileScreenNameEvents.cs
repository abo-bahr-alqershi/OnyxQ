using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new mobile screen name is created
/// حدث يتم رفعه عند إنشاء اسم شاشة موبايل جديد
/// </summary>
public class MobileScreenNameCreatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen name
    /// اسم شاشة الموبايل
    /// </summary>
    public MobileScreenName ScreenName { get; }

    public MobileScreenNameCreatedEvent(MobileScreenName screenName)
    {
        ScreenName = screenName;
    }
}

/// <summary>
/// Event raised when a mobile screen name is updated
/// حدث يتم رفعه عند تحديث اسم شاشة الموبايل
/// </summary>
public class MobileScreenNameUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the mobile screen name
    /// اسم شاشة الموبايل
    /// </summary>
    public MobileScreenName ScreenName { get; }

    public MobileScreenNameUpdatedEvent(MobileScreenName screenName)
    {
        ScreenName = screenName;
    }
} 