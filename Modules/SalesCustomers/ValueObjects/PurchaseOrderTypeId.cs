using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// PurchaseOrderType Identifier Value Object
/// </summary>
public sealed class PurchaseOrderTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PurchaseOrderType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PurchaseOrderTypeId instance
    /// </summary>
    public PurchaseOrderTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PurchaseOrderTypeId with a new GUID
    /// </summary>
    public static PurchaseOrderTypeId CreateUnique()
    {
        return new PurchaseOrderTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PurchaseOrderTypeId id) => id.Value.ToString();
    public static implicit operator Guid(PurchaseOrderTypeId id) => id.Value;
}
}
