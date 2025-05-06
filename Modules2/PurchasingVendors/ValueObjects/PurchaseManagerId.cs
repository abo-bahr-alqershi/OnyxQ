using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseManager Identifier Value Object
/// </summary>
public sealed class PurchaseManagerId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseManager
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseManagerId instance
    /// </summary>
    public PurchaseManagerId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseManagerId with a new GUID
    /// </summary>
    public static PurchaseManagerId CreateUnique()
    {
        return new PurchaseManagerId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseManagerId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseManagerId id) => id.Value;
}
}
