using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// InventoryItemDiscount Identifier Value Object
/// </summary>
public sealed class InventoryItemDiscountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InventoryItemDiscount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InventoryItemDiscountId instance
    /// </summary>
    public InventoryItemDiscountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InventoryItemDiscountId with a new GUID
    /// </summary>
    public static InventoryItemDiscountId CreateUnique()
    {
        return new InventoryItemDiscountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InventoryItemDiscountId id) => id.Value.ToString();
    public static implicit operator Guid(InventoryItemDiscountId id) => id.Value;
}
}
