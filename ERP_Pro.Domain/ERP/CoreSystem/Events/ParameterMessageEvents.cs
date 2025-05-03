using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a parameter message is created
/// حدث يتم رفعه عند إنشاء رسالة المعلمات
/// </summary>
public class ParameterMessageCreatedEvent : DomainEvent
{
    public ParameterMessage ParameterMessage { get; }

    public ParameterMessageCreatedEvent(ParameterMessage parameterMessage)
    {
        ParameterMessage = parameterMessage;
    }
}

/// <summary>
/// Event raised when a parameter message is updated
/// حدث يتم رفعه عند تحديث رسالة المعلمات
/// </summary>
public class ParameterMessageUpdatedEvent : DomainEvent
{
    public ParameterMessage ParameterMessage { get; }

    public ParameterMessageUpdatedEvent(ParameterMessage parameterMessage)
    {
        ParameterMessage = parameterMessage;
    }
}

/// <summary>
/// Event raised when a parameter message is deleted
/// حدث يتم رفعه عند حذف رسالة المعلمات
/// </summary>
public class ParameterMessageDeletedEvent : DomainEvent
{
    public ParameterMessage ParameterMessage { get; }

    public ParameterMessageDeletedEvent(ParameterMessage parameterMessage)
    {
        ParameterMessage = parameterMessage;
    }
} 