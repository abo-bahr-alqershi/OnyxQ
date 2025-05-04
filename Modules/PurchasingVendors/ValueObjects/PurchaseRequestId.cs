using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequest Identifier Value Object
/// </summary>
public sealed class PurchaseRequestId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequest
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestId instance
    /// </summary>
    public PurchaseRequestId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestId with a new GUID
    /// </summary>
    public static PurchaseRequestId CreateUnique()
    {
        return new PurchaseRequestId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestId id) => id.Value;
}
}
