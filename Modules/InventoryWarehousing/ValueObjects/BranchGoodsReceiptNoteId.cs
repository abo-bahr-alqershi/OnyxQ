using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchGoodsReceiptNote Identifier Value Object
/// </summary>
public sealed class BranchGoodsReceiptNoteId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchGoodsReceiptNote
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchGoodsReceiptNoteId instance
    /// </summary>
    public BranchGoodsReceiptNoteId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchGoodsReceiptNoteId with a new GUID
    /// </summary>
    public static BranchGoodsReceiptNoteId CreateUnique()
    {
        return new BranchGoodsReceiptNoteId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchGoodsReceiptNoteId id) => id.Value.ToString();
    public static implicit operator Guid(BranchGoodsReceiptNoteId id) => id.Value;
}
}
