using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxInputMovement Identifier Value Object
/// </summary>
public sealed class TaxInputMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxInputMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxInputMovementId instance
    /// </summary>
    public TaxInputMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxInputMovementId with a new GUID
    /// </summary>
    public static TaxInputMovementId CreateUnique()
    {
        return new TaxInputMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxInputMovementId id) => id.Value.ToString();
    public static implicit operator Guid(TaxInputMovementId id) => id.Value;
}
}
