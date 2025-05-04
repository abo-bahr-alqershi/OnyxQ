using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// GoodsReceiptNoteTypes Identifier Value Object
/// </summary>
public sealed class GoodsReceiptNoteTypesId : ValueObject
{
    /// <summary>
    /// The unique identifier for the GoodsReceiptNoteTypes
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new GoodsReceiptNoteTypesId instance
    /// </summary>
    public GoodsReceiptNoteTypesId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new GoodsReceiptNoteTypesId with a new GUID
    /// </summary>
    public static GoodsReceiptNoteTypesId CreateUnique()
    {
        return new GoodsReceiptNoteTypesId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(GoodsReceiptNoteTypesId id) => id.Value.ToString();
    public static implicit operator Guid(GoodsReceiptNoteTypesId id) => id.Value;
}
}
