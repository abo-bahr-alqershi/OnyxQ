using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a journal file detail is created
/// حدث يتم رفعه عند إنشاء تفاصيل ملف اليومية
/// </summary>
public class JournalFileDetailCreatedEvent : DomainEvent
{
    public JournalFileDetail Detail { get; }

    public JournalFileDetailCreatedEvent(JournalFileDetail detail)
    {
        Detail = detail;
    }
}

/// <summary>
/// Event raised when a journal file detail is updated
/// حدث يتم رفعه عند تحديث تفاصيل ملف اليومية
/// </summary>
public class JournalFileDetailUpdatedEvent : DomainEvent
{
    public JournalFileDetail Detail { get; }

    public JournalFileDetailUpdatedEvent(JournalFileDetail detail)
    {
        Detail = detail;
    }
} 