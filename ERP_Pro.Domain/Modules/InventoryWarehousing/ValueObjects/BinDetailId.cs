using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// BinDetail Identifier Value Object
/// </summary>
public sealed class BinDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BinDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BinDetailId instance
    /// </summary>
    public BinDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BinDetailId with a new GUID
    /// </summary>
    public static BinDetailId CreateUnique()
    {
        return new BinDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BinDetailId id) => id.Value.ToString();
    public static implicit operator Guid(BinDetailId id) => id.Value;
}
}
