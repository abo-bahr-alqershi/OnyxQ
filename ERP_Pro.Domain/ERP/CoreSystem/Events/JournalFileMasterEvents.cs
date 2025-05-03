using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a journal file master is created
/// حدث يتم رفعه عند إنشاء ملف اليومية الرئيسي
/// </summary>
public class JournalFileMasterCreatedEvent : DomainEvent
{
    public JournalFileMaster Master { get; }

    public JournalFileMasterCreatedEvent(JournalFileMaster master)
    {
        Master = master;
    }
}

/// <summary>
/// Event raised when a journal file master is updated
/// حدث يتم رفعه عند تحديث ملف اليومية الرئيسي
/// </summary>
public class JournalFileMasterUpdatedEvent : DomainEvent
{
    public JournalFileMaster Master { get; }

    public JournalFileMasterUpdatedEvent(JournalFileMaster master)
    {
        Master = master;
    }
}

/// <summary>
/// Event raised when a journal file master is deactivated
/// حدث يتم رفعه عند إلغاء تفعيل ملف اليومية الرئيسي
/// </summary>
public class JournalFileMasterDeactivatedEvent : DomainEvent
{
    public JournalFileMaster Master { get; }

    public JournalFileMasterDeactivatedEvent(JournalFileMaster master)
    {
        Master = master;
    }
}

/// <summary>
/// Event raised when a journal file master is activated
/// حدث يتم رفعه عند تفعيل ملف اليومية الرئيسي
/// </summary>
public class JournalFileMasterActivatedEvent : DomainEvent
{
    public JournalFileMaster Master { get; }

    public JournalFileMasterActivatedEvent(JournalFileMaster master)
    {
        Master = master;
    }
} 