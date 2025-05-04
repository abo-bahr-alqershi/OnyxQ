using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GateGoodsReceiptMaster Identifier Value Object
/// </summary>
public sealed class GateGoodsReceiptMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GateGoodsReceiptMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GateGoodsReceiptMasterId instance
    /// </summary>
    public GateGoodsReceiptMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GateGoodsReceiptMasterId with a new GUID
    /// </summary>
    public static GateGoodsReceiptMasterId CreateUnique()
    {
        return new GateGoodsReceiptMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GateGoodsReceiptMasterId id) => id.Value.ToString();
    public static implicit operator Guid(GateGoodsReceiptMasterId id) => id.Value;
}
}
