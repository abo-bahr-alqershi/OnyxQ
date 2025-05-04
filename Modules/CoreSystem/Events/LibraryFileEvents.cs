using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to LibraryFile entity
/// </summary>
public sealed class LibraryFileCreatedEvent : DomainEvent
{
    public LibraryFileId LibraryFileId { get; }

    public LibraryFileCreatedEvent(LibraryFileId libraryfileId)
    {
        LibraryFileId = libraryfileId;
    }
}

public sealed class LibraryFileUpdatedEvent : DomainEvent
{
    public LibraryFileId LibraryFileId { get; }

    public LibraryFileUpdatedEvent(LibraryFileId libraryfileId)
    {
        LibraryFileId = libraryfileId;
    }
}

public sealed class LibraryFileDeletedEvent : DomainEvent
{
    public LibraryFileId LibraryFileId { get; }

    public LibraryFileDeletedEvent(LibraryFileId libraryfileId)
    {
        LibraryFileId = libraryfileId;
    }
}
}
