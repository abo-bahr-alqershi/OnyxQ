using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// DisassembleKitItem Identifier Value Object
/// </summary>
public sealed class DisassembleKitItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DisassembleKitItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DisassembleKitItemId instance
    /// </summary>
    public DisassembleKitItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DisassembleKitItemId with a new GUID
    /// </summary>
    public static DisassembleKitItemId CreateUnique()
    {
        return new DisassembleKitItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DisassembleKitItemId id) => id.Value.ToString();
    public static implicit operator Guid(DisassembleKitItemId id) => id.Value;
}
}
