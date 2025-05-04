using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// AssembleKitItem Identifier Value Object
/// </summary>
public sealed class AssembleKitItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AssembleKitItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AssembleKitItemId instance
    /// </summary>
    public AssembleKitItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AssembleKitItemId with a new GUID
    /// </summary>
    public static AssembleKitItemId CreateUnique()
    {
        return new AssembleKitItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AssembleKitItemId id) => id.Value.ToString();
    public static implicit operator Guid(AssembleKitItemId id) => id.Value;
}
}
