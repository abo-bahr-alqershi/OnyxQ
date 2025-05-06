using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ItemUnitBarcode Identifier Value Object
/// </summary>
public sealed class ItemUnitBarcodeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ItemUnitBarcode
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ItemUnitBarcodeId instance
    /// </summary>
    public ItemUnitBarcodeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ItemUnitBarcodeId with a new GUID
    /// </summary>
    public static ItemUnitBarcodeId CreateUnique()
    {
        return new ItemUnitBarcodeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ItemUnitBarcodeId id) => id.Value.ToString();
    public static implicit operator Guid(ItemUnitBarcodeId id) => id.Value;
}
}
