using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxCodeMaster Identifier Value Object
/// </summary>
public sealed class TaxCodeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxCodeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxCodeMasterId instance
    /// </summary>
    public TaxCodeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxCodeMasterId with a new GUID
    /// </summary>
    public static TaxCodeMasterId CreateUnique()
    {
        return new TaxCodeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxCodeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(TaxCodeMasterId id) => id.Value;
}
}
