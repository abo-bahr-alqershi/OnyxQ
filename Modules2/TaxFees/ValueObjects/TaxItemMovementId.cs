using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxItemMovement Identifier Value Object
/// </summary>
public sealed class TaxItemMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxItemMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxItemMovementId instance
    /// </summary>
    public TaxItemMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxItemMovementId with a new GUID
    /// </summary>
    public static TaxItemMovementId CreateUnique()
    {
        return new TaxItemMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxItemMovementId id) => id.Value.ToString();
    public static implicit operator Guid(TaxItemMovementId id) => id.Value;
}
}
