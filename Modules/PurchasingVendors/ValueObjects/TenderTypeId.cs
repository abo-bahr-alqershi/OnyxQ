using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// TenderType Identifier Value Object
/// </summary>
public sealed class TenderTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the TenderType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new TenderTypeId instance
    /// </summary>
    public TenderTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new TenderTypeId with a new GUID
    /// </summary>
    public static TenderTypeId CreateUnique()
    {
        return new TenderTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(TenderTypeId id) => id.Value.ToString();
    public static implicit operator Guid(TenderTypeId id) => id.Value;
}
}
