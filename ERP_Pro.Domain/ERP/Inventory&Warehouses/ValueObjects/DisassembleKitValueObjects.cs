using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public record DisassembleKitInfo
    {
        public long? AssembleDocNo { get; }
        public long? AssembleDocSer { get; }
        public string? KitItemNo { get; }
        public string? ItemUnit { get; }
        public int? PackSize { get; }
        public int? ItemQty { get; }
        public int? KitCost { get; }

        private DisassembleKitInfo(
            long? assembleDocNo,
            long? assembleDocSer,
            string? kitItemNo,
            string? itemUnit,
            int? packSize,
            int? itemQty,
            int? kitCost)
        {
            AssembleDocNo = assembleDocNo;
            AssembleDocSer = assembleDocSer;
            KitItemNo = kitItemNo;
            ItemUnit = itemUnit;
            PackSize = packSize;
            ItemQty = itemQty;
            KitCost = kitCost;
        }

        public static DisassembleKitInfo Create(
            long? assembleDocNo,
            long? assembleDocSer,
            string? kitItemNo,
            string? itemUnit,
            int? packSize,
            int? itemQty,
            int? kitCost)
        {
            return new DisassembleKitInfo(assembleDocNo, assembleDocSer, kitItemNo, itemUnit, packSize, itemQty, kitCost);
        }
    }

    public record WarehouseInfo
    {
        public long? FromWarehouse { get; }
        public long? ToWarehouse { get; }

        private WarehouseInfo(long? fromWarehouse, long? toWarehouse)
        {
            FromWarehouse = fromWarehouse;
            ToWarehouse = toWarehouse;
        }

        public static WarehouseInfo Create(long? fromWarehouse, long? toWarehouse)
        {
            return new WarehouseInfo(fromWarehouse, toWarehouse);
        }
    }

    public record BatchInfo
    {
        public string? BatchNo { get; }
        public DateTime? ExpireDate { get; }

        private BatchInfo(string? batchNo, DateTime? expireDate)
        {
            BatchNo = batchNo;
            ExpireDate = expireDate;
        }

        public static BatchInfo Create(string? batchNo, DateTime? expireDate)
        {
            return new BatchInfo(batchNo, expireDate);
        }
    }
} 