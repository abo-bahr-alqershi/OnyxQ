using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// QuotationType Identifier Value Object
/// </summary>
public sealed class QuotationTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuotationType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuotationTypeId instance
    /// </summary>
    public QuotationTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuotationTypeId with a new GUID
    /// </summary>
    public static QuotationTypeId CreateUnique()
    {
        return new QuotationTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuotationTypeId id) => id.Value.ToString();
    public static implicit operator Guid(QuotationTypeId id) => id.Value;
}
}
