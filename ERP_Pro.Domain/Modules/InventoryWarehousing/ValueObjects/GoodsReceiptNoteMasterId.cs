using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptNoteMaster Identifier Value Object
/// </summary>
public sealed class GoodsReceiptNoteMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptNoteMasterId instance
    /// </summary>
    public GoodsReceiptNoteMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptNoteMasterId with a new GUID
    /// </summary>
    public static GoodsReceiptNoteMasterId CreateUnique()
    {
        return new GoodsReceiptNoteMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptNoteMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptNoteMasterId id) => id.Value;
}
}
