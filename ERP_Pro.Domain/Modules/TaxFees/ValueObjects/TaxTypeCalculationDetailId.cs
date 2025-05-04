using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxTypeCalculationDetail Identifier Value Object
/// </summary>
public sealed class TaxTypeCalculationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxTypeCalculationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxTypeCalculationDetailId instance
    /// </summary>
    public TaxTypeCalculationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxTypeCalculationDetailId with a new GUID
    /// </summary>
    public static TaxTypeCalculationDetailId CreateUnique()
    {
        return new TaxTypeCalculationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxTypeCalculationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(TaxTypeCalculationDetailId id) => id.Value;
}
}
