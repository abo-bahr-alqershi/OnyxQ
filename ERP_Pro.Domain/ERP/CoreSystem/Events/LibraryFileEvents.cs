using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a library file is created
/// حدث يتم رفعه عند إنشاء ملف المكتبة
/// </summary>
public class LibraryFileCreatedEvent : DomainEvent
{
    public LibraryFile File { get; }

    public LibraryFileCreatedEvent(LibraryFile file)
    {
        File = file;
    }
}

/// <summary>
/// Event raised when a library file is updated
/// حدث يتم رفعه عند تحديث ملف المكتبة
/// </summary>
public class LibraryFileUpdatedEvent : DomainEvent
{
    public LibraryFile File { get; }

    public LibraryFileUpdatedEvent(LibraryFile file)
    {
        File = file;
    }
}

/// <summary>
/// Event raised when a library file is deactivated
/// حدث يتم رفعه عند إلغاء تفعيل ملف المكتبة
/// </summary>
public class LibraryFileDeactivatedEvent : DomainEvent
{
    public LibraryFile File { get; }

    public LibraryFileDeactivatedEvent(LibraryFile file)
    {
        File = file;
    }
}

/// <summary>
/// Event raised when a library file is activated
/// حدث يتم رفعه عند تفعيل ملف المكتبة
/// </summary>
public class LibraryFileActivatedEvent : DomainEvent
{
    public LibraryFile File { get; }

    public LibraryFileActivatedEvent(LibraryFile file)
    {
        File = file;
    }
} 