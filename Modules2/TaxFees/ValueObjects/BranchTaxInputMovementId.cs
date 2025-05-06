using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// BranchTaxInputMovement Identifier Value Object
/// </summary>
public sealed class BranchTaxInputMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchTaxInputMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchTaxInputMovementId instance
    /// </summary>
    public BranchTaxInputMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchTaxInputMovementId with a new GUID
    /// </summary>
    public static BranchTaxInputMovementId CreateUnique()
    {
        return new BranchTaxInputMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchTaxInputMovementId id) => id.Value.ToString();
    public static implicit operator Guid(BranchTaxInputMovementId id) => id.Value;
}
}
