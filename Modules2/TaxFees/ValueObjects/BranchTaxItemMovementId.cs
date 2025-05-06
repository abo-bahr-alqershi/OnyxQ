using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// BranchTaxItemMovement Identifier Value Object
/// </summary>
public sealed class BranchTaxItemMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchTaxItemMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchTaxItemMovementId instance
    /// </summary>
    public BranchTaxItemMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchTaxItemMovementId with a new GUID
    /// </summary>
    public static BranchTaxItemMovementId CreateUnique()
    {
        return new BranchTaxItemMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchTaxItemMovementId id) => id.Value.ToString();
    public static implicit operator Guid(BranchTaxItemMovementId id) => id.Value;
}
}
