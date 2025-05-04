using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchasePlanMaster Identifier Value Object
/// </summary>
public sealed class PurchasePlanMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchasePlanMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchasePlanMasterId instance
    /// </summary>
    public PurchasePlanMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchasePlanMasterId with a new GUID
    /// </summary>
    public static PurchasePlanMasterId CreateUnique()
    {
        return new PurchasePlanMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchasePlanMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PurchasePlanMasterId id) => id.Value;
}
}
