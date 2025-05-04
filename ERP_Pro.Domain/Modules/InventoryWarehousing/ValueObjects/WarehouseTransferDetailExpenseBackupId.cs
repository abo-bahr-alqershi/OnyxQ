using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// WarehouseTransferDetailExpenseBackup Identifier Value Object
/// </summary>
public sealed class WarehouseTransferDetailExpenseBackupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the WarehouseTransferDetailExpenseBackup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new WarehouseTransferDetailExpenseBackupId instance
    /// </summary>
    public WarehouseTransferDetailExpenseBackupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new WarehouseTransferDetailExpenseBackupId with a new GUID
    /// </summary>
    public static WarehouseTransferDetailExpenseBackupId CreateUnique()
    {
        return new WarehouseTransferDetailExpenseBackupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(WarehouseTransferDetailExpenseBackupId id) => id.Value.ToString();
    public static implicit operator Guid(WarehouseTransferDetailExpenseBackupId id) => id.Value;
}
}
