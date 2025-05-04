using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseBillDetail Identifier Value Object
/// </summary>
public sealed class PurchaseBillDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseBillDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseBillDetailId instance
    /// </summary>
    public PurchaseBillDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseBillDetailId with a new GUID
    /// </summary>
    public static PurchaseBillDetailId CreateUnique()
    {
        return new PurchaseBillDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseBillDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseBillDetailId id) => id.Value;
}
}
