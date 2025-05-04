using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseBillMaster Identifier Value Object
/// </summary>
public sealed class PurchaseBillMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseBillMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseBillMasterId instance
    /// </summary>
    public PurchaseBillMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseBillMasterId with a new GUID
    /// </summary>
    public static PurchaseBillMasterId CreateUnique()
    {
        return new PurchaseBillMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseBillMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseBillMasterId id) => id.Value;
}
}
