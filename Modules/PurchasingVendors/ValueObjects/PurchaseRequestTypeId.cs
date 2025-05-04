using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequestType Identifier Value Object
/// </summary>
public sealed class PurchaseRequestTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequestType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestTypeId instance
    /// </summary>
    public PurchaseRequestTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestTypeId with a new GUID
    /// </summary>
    public static PurchaseRequestTypeId CreateUnique()
    {
        return new PurchaseRequestTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestTypeId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestTypeId id) => id.Value;
}
}
