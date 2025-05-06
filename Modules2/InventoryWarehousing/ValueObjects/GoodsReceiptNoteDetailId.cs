using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptNoteDetail Identifier Value Object
/// </summary>
public sealed class GoodsReceiptNoteDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptNoteDetailId instance
    /// </summary>
    public GoodsReceiptNoteDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptNoteDetailId with a new GUID
    /// </summary>
    public static GoodsReceiptNoteDetailId CreateUnique()
    {
        return new GoodsReceiptNoteDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptNoteDetailId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptNoteDetailId id) => id.Value;
}
}
