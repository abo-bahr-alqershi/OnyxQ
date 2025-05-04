using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BranchGoodsReceiptDetail Identifier Value Object
/// </summary>
public sealed class BranchGoodsReceiptDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchGoodsReceiptDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchGoodsReceiptDetailId instance
    /// </summary>
    public BranchGoodsReceiptDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchGoodsReceiptDetailId with a new GUID
    /// </summary>
    public static BranchGoodsReceiptDetailId CreateUnique()
    {
        return new BranchGoodsReceiptDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchGoodsReceiptDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BranchGoodsReceiptDetailId id) => id.Value;
}
}
