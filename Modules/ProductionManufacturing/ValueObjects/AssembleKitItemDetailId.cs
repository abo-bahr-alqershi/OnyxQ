using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects
{
/// <summary>
/// AssembleKitItemDetail Identifier Value Object
/// </summary>
public sealed class AssembleKitItemDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AssembleKitItemDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AssembleKitItemDetailId instance
    /// </summary>
    public AssembleKitItemDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AssembleKitItemDetailId with a new GUID
    /// </summary>
    public static AssembleKitItemDetailId CreateUnique()
    {
        return new AssembleKitItemDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AssembleKitItemDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AssembleKitItemDetailId id) => id.Value;
}
}
