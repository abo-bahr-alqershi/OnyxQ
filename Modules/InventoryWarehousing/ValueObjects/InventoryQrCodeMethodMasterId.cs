using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryQrCodeMethodMaster Identifier Value Object
/// </summary>
public sealed class InventoryQrCodeMethodMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryQrCodeMethodMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryQrCodeMethodMasterId instance
    /// </summary>
    public InventoryQrCodeMethodMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryQrCodeMethodMasterId with a new GUID
    /// </summary>
    public static InventoryQrCodeMethodMasterId CreateUnique()
    {
        return new InventoryQrCodeMethodMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryQrCodeMethodMasterId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryQrCodeMethodMasterId id) => id.Value;
}
}
