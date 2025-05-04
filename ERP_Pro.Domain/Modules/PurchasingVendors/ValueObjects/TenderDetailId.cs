using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// TenderDetail Identifier Value Object
/// </summary>
public sealed class TenderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TenderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TenderDetailId instance
    /// </summary>
    public TenderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TenderDetailId with a new GUID
    /// </summary>
    public static TenderDetailId CreateUnique()
    {
        return new TenderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TenderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(TenderDetailId id) => id.Value;
}
}
