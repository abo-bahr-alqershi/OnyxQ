using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Events
{
    public class WarehouseTransferExpenseBranchCreatedEvent : DomainEvent
    {
        public WarehouseTransferExpenseBranch Transfer { get; }

        public WarehouseTransferExpenseBranchCreatedEvent(WarehouseTransferExpenseBranch transfer)
        {
            Transfer = transfer;
        }
    }

    public class WarehouseTransferExpenseBranchUpdatedEvent : DomainEvent
    {
        public WarehouseTransferExpenseBranch Transfer { get; }

        public WarehouseTransferExpenseBranchUpdatedEvent(WarehouseTransferExpenseBranch transfer)
        {
            Transfer = transfer;
        }
    }
} 