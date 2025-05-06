using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptIncomingMaster Identifier Value Object
/// </summary>
public sealed class GoodsReceiptIncomingMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptIncomingMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptIncomingMasterId instance
    /// </summary>
    public GoodsReceiptIncomingMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptIncomingMasterId with a new GUID
    /// </summary>
    public static GoodsReceiptIncomingMasterId CreateUnique()
    {
        return new GoodsReceiptIncomingMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptIncomingMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptIncomingMasterId id) => id.Value;
}
}
