using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseOrderDetailBackupTemp Identifier Value Object
/// </summary>
public sealed class PurchaseOrderDetailBackupTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseOrderDetailBackupTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseOrderDetailBackupTempId instance
    /// </summary>
    public PurchaseOrderDetailBackupTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseOrderDetailBackupTempId with a new GUID
    /// </summary>
    public static PurchaseOrderDetailBackupTempId CreateUnique()
    {
        return new PurchaseOrderDetailBackupTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseOrderDetailBackupTempId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseOrderDetailBackupTempId id) => id.Value;
}
}
