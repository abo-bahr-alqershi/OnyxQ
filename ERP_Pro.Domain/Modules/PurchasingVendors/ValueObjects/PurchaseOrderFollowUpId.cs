using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// PurchaseOrderFollowUp Identifier Value Object
/// </summary>
public sealed class PurchaseOrderFollowUpId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseOrderFollowUp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseOrderFollowUpId instance
    /// </summary>
    public PurchaseOrderFollowUpId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseOrderFollowUpId with a new GUID
    /// </summary>
    public static PurchaseOrderFollowUpId CreateUnique()
    {
        return new PurchaseOrderFollowUpId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseOrderFollowUpId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseOrderFollowUpId id) => id.Value;
}
}
