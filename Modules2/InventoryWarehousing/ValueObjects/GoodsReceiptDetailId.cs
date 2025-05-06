using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptDetail Identifier Value Object
/// </summary>
public sealed class GoodsReceiptDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptDetailId instance
    /// </summary>
    public GoodsReceiptDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptDetailId with a new GUID
    /// </summary>
    public static GoodsReceiptDetailId CreateUnique()
    {
        return new GoodsReceiptDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptDetailId id) => id.Value;
}
}
