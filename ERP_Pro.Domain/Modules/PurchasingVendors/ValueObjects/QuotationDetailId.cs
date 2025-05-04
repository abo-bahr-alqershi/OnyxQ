using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// QuotationDetail Identifier Value Object
/// </summary>
public sealed class QuotationDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuotationDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationDetailId instance
    /// </summary>
    public QuotationDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationDetailId with a new GUID
    /// </summary>
    public static QuotationDetailId CreateUnique()
    {
        return new QuotationDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationDetailId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationDetailId id) => id.Value;
}
}
