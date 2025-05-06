using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxInput Identifier Value Object
/// </summary>
public sealed class TaxInputId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxInput
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxInputId instance
    /// </summary>
    public TaxInputId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxInputId with a new GUID
    /// </summary>
    public static TaxInputId CreateUnique()
    {
        return new TaxInputId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxInputId id) => id.Value.ToString();
    public static implicit operator Guid(TaxInputId id) => id.Value;
}
}
