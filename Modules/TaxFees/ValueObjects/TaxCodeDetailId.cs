using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxCodeDetail Identifier Value Object
/// </summary>
public sealed class TaxCodeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxCodeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxCodeDetailId instance
    /// </summary>
    public TaxCodeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxCodeDetailId with a new GUID
    /// </summary>
    public static TaxCodeDetailId CreateUnique()
    {
        return new TaxCodeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxCodeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(TaxCodeDetailId id) => id.Value;
}
}
