using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a connect contact is created
/// حدث يتم رفعه عند إنشاء جهة اتصال
/// </summary>
public class ConnectContactCreatedEvent : DomainEvent
{
    public ConnectContact Contact { get; }

    public ConnectContactCreatedEvent(ConnectContact contact)
    {
        Contact = contact;
    }
}

/// <summary>
/// Event raised when a connect contact is updated
/// حدث يتم رفعه عند تحديث جهة اتصال
/// </summary>
public class ConnectContactUpdatedEvent : DomainEvent
{
    public ConnectContact Contact { get; }

    public ConnectContactUpdatedEvent(ConnectContact contact)
    {
        Contact = contact;
    }
}

/// <summary>
/// Event raised when a connect contact is deactivated
/// حدث يتم رفعه عند إلغاء تفعيل جهة اتصال
/// </summary>
public class ConnectContactDeactivatedEvent : DomainEvent
{
    public ConnectContact Contact { get; }

    public ConnectContactDeactivatedEvent(ConnectContact contact)
    {
        Contact = contact;
    }
}

/// <summary>
/// Event raised when a connect contact is activated
/// حدث يتم رفعه عند تفعيل جهة اتصال
/// </summary>
public class ConnectContactActivatedEvent : DomainEvent
{
    public ConnectContact Contact { get; }

    public ConnectContactActivatedEvent(ConnectContact contact)
    {
        Contact = contact;
    }
} 