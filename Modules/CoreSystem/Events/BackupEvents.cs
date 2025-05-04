using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Backup entity
/// </summary>
public sealed class BackupCreatedEvent : DomainEvent
{
    public BackupId BackupId { get; }

    public BackupCreatedEvent(BackupId backupId)
    {
        BackupId = backupId;
    }
}

public sealed class BackupUpdatedEvent : DomainEvent
{
    public BackupId BackupId { get; }

    public BackupUpdatedEvent(BackupId backupId)
    {
        BackupId = backupId;
    }
}

public sealed class BackupDeletedEvent : DomainEvent
{
    public BackupId BackupId { get; }

    public BackupDeletedEvent(BackupId backupId)
    {
        BackupId = backupId;
    }
}
}
