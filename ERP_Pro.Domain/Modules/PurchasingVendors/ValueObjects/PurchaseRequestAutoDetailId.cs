using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequestAutoDetail Identifier Value Object
/// </summary>
public sealed class PurchaseRequestAutoDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequestAutoDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestAutoDetailId instance
    /// </summary>
    public PurchaseRequestAutoDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestAutoDetailId with a new GUID
    /// </summary>
    public static PurchaseRequestAutoDetailId CreateUnique()
    {
        return new PurchaseRequestAutoDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestAutoDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestAutoDetailId id) => id.Value;
}
}
