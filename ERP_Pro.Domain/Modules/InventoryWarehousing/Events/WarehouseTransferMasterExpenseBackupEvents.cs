using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to WarehouseTransferMasterExpenseBackup entity
/// </summary>
public sealed class WarehouseTransferMasterExpenseBackupCreatedEvent : DomainEvent
{
    public WarehouseTransferMasterExpenseBackupId WarehouseTransferMasterExpenseBackupId { get; }

    public WarehouseTransferMasterExpenseBackupCreatedEvent(WarehouseTransferMasterExpenseBackupId warehousetransfermasterexpensebackupId)
    {
        WarehouseTransferMasterExpenseBackupId = warehousetransfermasterexpensebackupId;
    }
}

public sealed class WarehouseTransferMasterExpenseBackupUpdatedEvent : DomainEvent
{
    public WarehouseTransferMasterExpenseBackupId WarehouseTransferMasterExpenseBackupId { get; }

    public WarehouseTransferMasterExpenseBackupUpdatedEvent(WarehouseTransferMasterExpenseBackupId warehousetransfermasterexpensebackupId)
    {
        WarehouseTransferMasterExpenseBackupId = warehousetransfermasterexpensebackupId;
    }
}

public sealed class WarehouseTransferMasterExpenseBackupDeletedEvent : DomainEvent
{
    public WarehouseTransferMasterExpenseBackupId WarehouseTransferMasterExpenseBackupId { get; }

    public WarehouseTransferMasterExpenseBackupDeletedEvent(WarehouseTransferMasterExpenseBackupId warehousetransfermasterexpensebackupId)
    {
        WarehouseTransferMasterExpenseBackupId = warehousetransfermasterexpensebackupId;
    }
}
}
