using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequestDetail Identifier Value Object
/// </summary>
public sealed class PurchaseRequestDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequestDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestDetailId instance
    /// </summary>
    public PurchaseRequestDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestDetailId with a new GUID
    /// </summary>
    public static PurchaseRequestDetailId CreateUnique()
    {
        return new PurchaseRequestDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestDetailId id) => id.Value;
}
}
