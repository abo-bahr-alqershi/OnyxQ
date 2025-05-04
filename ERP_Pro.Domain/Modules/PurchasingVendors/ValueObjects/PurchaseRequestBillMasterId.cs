using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequestBillMaster Identifier Value Object
/// </summary>
public sealed class PurchaseRequestBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequestBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestBillMasterId instance
    /// </summary>
    public PurchaseRequestBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestBillMasterId with a new GUID
    /// </summary>
    public static PurchaseRequestBillMasterId CreateUnique()
    {
        return new PurchaseRequestBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestBillMasterId id) => id.Value;
}
}
