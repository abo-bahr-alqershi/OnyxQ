using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchasePlanDetail Identifier Value Object
/// </summary>
public sealed class PurchasePlanDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchasePlanDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchasePlanDetailId instance
    /// </summary>
    public PurchasePlanDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchasePlanDetailId with a new GUID
    /// </summary>
    public static PurchasePlanDetailId CreateUnique()
    {
        return new PurchasePlanDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchasePlanDetailId id) => id.Value.ToString();
    public static implicit operator Guid(PurchasePlanDetailId id) => id.Value;
}
}
