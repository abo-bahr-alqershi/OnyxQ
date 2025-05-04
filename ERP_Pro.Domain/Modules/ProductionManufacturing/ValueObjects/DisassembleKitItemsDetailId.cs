using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// DisassembleKitItemsDetail Identifier Value Object
/// </summary>
public sealed class DisassembleKitItemsDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DisassembleKitItemsDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DisassembleKitItemsDetailId instance
    /// </summary>
    public DisassembleKitItemsDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DisassembleKitItemsDetailId with a new GUID
    /// </summary>
    public static DisassembleKitItemsDetailId CreateUnique()
    {
        return new DisassembleKitItemsDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DisassembleKitItemsDetailId id) => id.Value.ToString();
    public static implicit operator Guid(DisassembleKitItemsDetailId id) => id.Value;
}
}
