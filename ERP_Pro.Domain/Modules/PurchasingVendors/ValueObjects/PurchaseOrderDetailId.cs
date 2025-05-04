using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseOrderDetail Identifier Value Object
/// </summary>
public sealed class PurchaseOrderDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseOrderDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseOrderDetailId instance
    /// </summary>
    public PurchaseOrderDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseOrderDetailId with a new GUID
    /// </summary>
    public static PurchaseOrderDetailId CreateUnique()
    {
        return new PurchaseOrderDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseOrderDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseOrderDetailId id) => id.Value;
}
}
