using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// BranchRequestTaxItemMovement Identifier Value Object
/// </summary>
public sealed class BranchRequestTaxItemMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BranchRequestTaxItemMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BranchRequestTaxItemMovementId instance
    /// </summary>
    public BranchRequestTaxItemMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BranchRequestTaxItemMovementId with a new GUID
    /// </summary>
    public static BranchRequestTaxItemMovementId CreateUnique()
    {
        return new BranchRequestTaxItemMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BranchRequestTaxItemMovementId id) => id.Value.ToString();
    public static implicit operator Guid(BranchRequestTaxItemMovementId id) => id.Value;
}
}
