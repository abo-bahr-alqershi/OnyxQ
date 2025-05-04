using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequestBillDetail Identifier Value Object
/// </summary>
public sealed class PurchaseRequestBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequestBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestBillDetailId instance
    /// </summary>
    public PurchaseRequestBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestBillDetailId with a new GUID
    /// </summary>
    public static PurchaseRequestBillDetailId CreateUnique()
    {
        return new PurchaseRequestBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestBillDetailId id) => id.Value;
}
}
