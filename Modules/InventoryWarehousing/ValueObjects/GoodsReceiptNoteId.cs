using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptNote Identifier Value Object
/// </summary>
public sealed class GoodsReceiptNoteId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptNote
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptNoteId instance
    /// </summary>
    public GoodsReceiptNoteId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptNoteId with a new GUID
    /// </summary>
    public static GoodsReceiptNoteId CreateUnique()
    {
        return new GoodsReceiptNoteId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptNoteId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptNoteId id) => id.Value;
}
}
