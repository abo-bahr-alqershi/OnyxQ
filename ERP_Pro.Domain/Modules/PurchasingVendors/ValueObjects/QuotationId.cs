using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// Quotation Identifier Value Object
/// </summary>
public sealed class QuotationId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Quotation
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationId instance
    /// </summary>
    public QuotationId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationId with a new GUID
    /// </summary>
    public static QuotationId CreateUnique()
    {
        return new QuotationId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationId id) => id.Value;
}
}
