using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// ApprovedMovement Identifier Value Object
/// </summary>
public sealed class ApprovedMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ApprovedMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ApprovedMovementId instance
    /// </summary>
    public ApprovedMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ApprovedMovementId with a new GUID
    /// </summary>
    public static ApprovedMovementId CreateUnique()
    {
        return new ApprovedMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ApprovedMovementId id) => id.Value.ToString();
    public static implicit operator Guid(ApprovedMovementId id) => id.Value;
}
}
