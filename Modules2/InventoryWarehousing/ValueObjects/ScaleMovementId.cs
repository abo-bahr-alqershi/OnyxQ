using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// ScaleMovement Identifier Value Object
/// </summary>
public sealed class ScaleMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ScaleMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ScaleMovementId instance
    /// </summary>
    public ScaleMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ScaleMovementId with a new GUID
    /// </summary>
    public static ScaleMovementId CreateUnique()
    {
        return new ScaleMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ScaleMovementId id) => id.Value.ToString();
    public static implicit operator Guid(ScaleMovementId id) => id.Value;
}
}
