using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptIncomingDetail Identifier Value Object
/// </summary>
public sealed class GoodsReceiptIncomingDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptIncomingDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptIncomingDetailId instance
    /// </summary>
    public GoodsReceiptIncomingDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptIncomingDetailId with a new GUID
    /// </summary>
    public static GoodsReceiptIncomingDetailId CreateUnique()
    {
        return new GoodsReceiptIncomingDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptIncomingDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptIncomingDetailId id) => id.Value;
}
}
