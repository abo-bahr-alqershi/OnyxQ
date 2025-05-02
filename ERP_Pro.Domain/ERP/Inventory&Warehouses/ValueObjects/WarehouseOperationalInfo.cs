using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public class WarehouseOperationalInfo : ValueObject
    {
        public int SerialNumber { get; private set; }
        public int? BranchNumber { get; private set; }
        public int? ActivityNumber { get; private set; }
        public long? MainWarehouseCode { get; private set; }
        public string? DatabaseLinkName { get; private set; }
        public bool UseProportionFlag { get; private set; }
        public int? ShowWarehouseType { get; private set; }
        public int? ShowSystemType { get; private set; }

        private WarehouseOperationalInfo() { } // For EF Core

        public WarehouseOperationalInfo(
            int serialNumber,
            int? branchNumber = null,
            int? activityNumber = null,
            long? mainWarehouseCode = null,
            string? databaseLinkName = null,
            bool useProportionFlag = false,
            int? showWarehouseType = null,
            int? showSystemType = null)
        {
            SerialNumber = serialNumber;
            BranchNumber = branchNumber;
            ActivityNumber = activityNumber;
            MainWarehouseCode = mainWarehouseCode;
            DatabaseLinkName = databaseLinkName;
            UseProportionFlag = useProportionFlag;
            ShowWarehouseType = showWarehouseType;
            ShowSystemType = showSystemType;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return SerialNumber;
            yield return BranchNumber ?? 0;
            yield return ActivityNumber ?? 0;
            yield return MainWarehouseCode ?? 0;
            yield return DatabaseLinkName ?? string.Empty;
            yield return UseProportionFlag;
            yield return ShowWarehouseType ?? 0;
            yield return ShowSystemType ?? 0;
        }

        public WarehouseOperationalInfo Update(
            int? branchNumber = null,
            int? activityNumber = null,
            long? mainWarehouseCode = null,
            string? databaseLinkName = null,
            bool? useProportionFlag = null,
            int? showWarehouseType = null,
            int? showSystemType = null)
        {
            return new WarehouseOperationalInfo(
                SerialNumber,
                branchNumber ?? BranchNumber,
                activityNumber ?? ActivityNumber,
                mainWarehouseCode ?? MainWarehouseCode,
                databaseLinkName ?? DatabaseLinkName,
                useProportionFlag ?? UseProportionFlag,
                showWarehouseType ?? ShowWarehouseType,
                showSystemType ?? ShowSystemType
            );
        }
    }
} 