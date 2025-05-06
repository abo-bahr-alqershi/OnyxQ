using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseOrder Identifier Value Object
/// </summary>
public sealed class PurchaseOrderId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseOrder
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseOrderId instance
    /// </summary>
    public PurchaseOrderId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseOrderId with a new GUID
    /// </summary>
    public static PurchaseOrderId CreateUnique()
    {
        return new PurchaseOrderId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseOrderId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseOrderId id) => id.Value;
}
}
