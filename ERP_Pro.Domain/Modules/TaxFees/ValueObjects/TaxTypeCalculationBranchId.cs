using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxTypeCalculationBranch Identifier Value Object
/// </summary>
public sealed class TaxTypeCalculationBranchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxTypeCalculationBranch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxTypeCalculationBranchId instance
    /// </summary>
    public TaxTypeCalculationBranchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxTypeCalculationBranchId with a new GUID
    /// </summary>
    public static TaxTypeCalculationBranchId CreateUnique()
    {
        return new TaxTypeCalculationBranchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxTypeCalculationBranchId id) => id.Value.ToString();
    public static implicit operator Guid(TaxTypeCalculationBranchId id) => id.Value;
}
}
