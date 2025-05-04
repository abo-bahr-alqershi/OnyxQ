using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TaxFees.ValueObjects
{
/// <summary>
/// TaxItem Identifier Value Object
/// </summary>
public sealed class TaxItemId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TaxItem
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TaxItemId instance
    /// </summary>
    public TaxItemId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TaxItemId with a new GUID
    /// </summary>
    public static TaxItemId CreateUnique()
    {
        return new TaxItemId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TaxItemId id) => id.Value.ToString();
    public static implicit operator Guid(TaxItemId id) => id.Value;
}
}
