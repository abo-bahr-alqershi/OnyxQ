using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryBarcodeConfig Identifier Value Object
/// </summary>
public sealed class InventoryBarcodeConfigId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryBarcodeConfig
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryBarcodeConfigId instance
    /// </summary>
    public InventoryBarcodeConfigId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryBarcodeConfigId with a new GUID
    /// </summary>
    public static InventoryBarcodeConfigId CreateUnique()
    {
        return new InventoryBarcodeConfigId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryBarcodeConfigId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryBarcodeConfigId id) => id.Value;
}
}
