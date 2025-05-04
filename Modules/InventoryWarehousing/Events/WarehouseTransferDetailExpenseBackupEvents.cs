using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseTransferDetailExpenseBackup entity
/// </summary>
public sealed class WarehouseTransferDetailExpenseBackupCreatedEvent : DomainEvent
{
    public WarehouseTransferDetailExpenseBackupId WarehouseTransferDetailExpenseBackupId { get; }

    public WarehouseTransferDetailExpenseBackupCreatedEvent(WarehouseTransferDetailExpenseBackupId warehousetransferdetailexpensebackupId)
    {
        WarehouseTransferDetailExpenseBackupId = warehousetransferdetailexpensebackupId;
    }
}

public sealed class WarehouseTransferDetailExpenseBackupUpdatedEvent : DomainEvent
{
    public WarehouseTransferDetailExpenseBackupId WarehouseTransferDetailExpenseBackupId { get; }

    public WarehouseTransferDetailExpenseBackupUpdatedEvent(WarehouseTransferDetailExpenseBackupId warehousetransferdetailexpensebackupId)
    {
        WarehouseTransferDetailExpenseBackupId = warehousetransferdetailexpensebackupId;
    }
}

public sealed class WarehouseTransferDetailExpenseBackupDeletedEvent : DomainEvent
{
    public WarehouseTransferDetailExpenseBackupId WarehouseTransferDetailExpenseBackupId { get; }

    public WarehouseTransferDetailExpenseBackupDeletedEvent(WarehouseTransferDetailExpenseBackupId warehousetransferdetailexpensebackupId)
    {
        WarehouseTransferDetailExpenseBackupId = warehousetransferdetailexpensebackupId;
    }
}
}
