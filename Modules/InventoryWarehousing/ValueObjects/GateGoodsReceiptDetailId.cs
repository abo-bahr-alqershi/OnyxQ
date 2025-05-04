using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GateGoodsReceiptDetail Identifier Value Object
/// </summary>
public sealed class GateGoodsReceiptDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GateGoodsReceiptDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GateGoodsReceiptDetailId instance
    /// </summary>
    public GateGoodsReceiptDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GateGoodsReceiptDetailId with a new GUID
    /// </summary>
    public static GateGoodsReceiptDetailId CreateUnique()
    {
        return new GateGoodsReceiptDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GateGoodsReceiptDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GateGoodsReceiptDetailId id) => id.Value;
}
}
