using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// DisassembleKitItemDetail Identifier Value Object
/// </summary>
public sealed class DisassembleKitItemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DisassembleKitItemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DisassembleKitItemDetailId instance
    /// </summary>
    public DisassembleKitItemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DisassembleKitItemDetailId with a new GUID
    /// </summary>
    public static DisassembleKitItemDetailId CreateUnique()
    {
        return new DisassembleKitItemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DisassembleKitItemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(DisassembleKitItemDetailId id) => id.Value;
}
}
