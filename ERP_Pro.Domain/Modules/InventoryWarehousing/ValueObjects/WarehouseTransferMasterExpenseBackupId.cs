using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseTransferMasterExpenseBackup Identifier Value Object
/// </summary>
public sealed class WarehouseTransferMasterExpenseBackupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseTransferMasterExpenseBackup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseTransferMasterExpenseBackupId instance
    /// </summary>
    public WarehouseTransferMasterExpenseBackupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseTransferMasterExpenseBackupId with a new GUID
    /// </summary>
    public static WarehouseTransferMasterExpenseBackupId CreateUnique()
    {
        return new WarehouseTransferMasterExpenseBackupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseTransferMasterExpenseBackupId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseTransferMasterExpenseBackupId id) => id.Value;
}
}
