using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryItemQrCode Identifier Value Object
/// </summary>
public sealed class InventoryItemQrCodeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryItemQrCode
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryItemQrCodeId instance
    /// </summary>
    public InventoryItemQrCodeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryItemQrCodeId with a new GUID
    /// </summary>
    public static InventoryItemQrCodeId CreateUnique()
    {
        return new InventoryItemQrCodeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryItemQrCodeId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryItemQrCodeId id) => id.Value;
}
}
