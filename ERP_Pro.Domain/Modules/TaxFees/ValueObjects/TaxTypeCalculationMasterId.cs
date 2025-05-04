using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxTypeCalculationMaster Identifier Value Object
/// </summary>
public sealed class TaxTypeCalculationMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxTypeCalculationMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxTypeCalculationMasterId instance
    /// </summary>
    public TaxTypeCalculationMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxTypeCalculationMasterId with a new GUID
    /// </summary>
    public static TaxTypeCalculationMasterId CreateUnique()
    {
        return new TaxTypeCalculationMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxTypeCalculationMasterId id) => id.Value.ToString();
    public static implicit operator Guid(TaxTypeCalculationMasterId id) => id.Value;
}
}
