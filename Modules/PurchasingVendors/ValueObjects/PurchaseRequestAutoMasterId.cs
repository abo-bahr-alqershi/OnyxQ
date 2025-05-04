using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseRequestAutoMaster Identifier Value Object
/// </summary>
public sealed class PurchaseRequestAutoMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseRequestAutoMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseRequestAutoMasterId instance
    /// </summary>
    public PurchaseRequestAutoMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseRequestAutoMasterId with a new GUID
    /// </summary>
    public static PurchaseRequestAutoMasterId CreateUnique()
    {
        return new PurchaseRequestAutoMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseRequestAutoMasterId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseRequestAutoMasterId id) => id.Value;
}
}
