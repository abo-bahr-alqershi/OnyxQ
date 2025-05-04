using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryQrCodeMethodDetail Identifier Value Object
/// </summary>
public sealed class InventoryQrCodeMethodDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryQrCodeMethodDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryQrCodeMethodDetailId instance
    /// </summary>
    public InventoryQrCodeMethodDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryQrCodeMethodDetailId with a new GUID
    /// </summary>
    public static InventoryQrCodeMethodDetailId CreateUnique()
    {
        return new InventoryQrCodeMethodDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryQrCodeMethodDetailId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryQrCodeMethodDetailId id) => id.Value;
}
}
